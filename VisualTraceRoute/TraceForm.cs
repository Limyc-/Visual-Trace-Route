using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;

//http://greatmaps.codeplex.com/

namespace VisualTraceRoute
{
	public partial class TraceForm : Form
	{
		private GMapOverlay pointOverlay;
		private GMapOverlay routeOverlay;
		private IPAddress targetAddress;
		private int hopLimit = 30;
		private int incrementValue = 1;

		public TraceForm()
		{
			InitializeComponent();
		}

		private void map_Load(object sender, EventArgs e)
		{
			map.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;

			pointOverlay = new GMapOverlay(map, "Points");
			routeOverlay = new GMapOverlay(map, "Routes");
		}

		private void addressTb_TextChanged(object sender, EventArgs e)
		{
			loadMapBtn.Enabled = false;
			addressLc.Visible = true;
			addressLc.Active = true;

			if (dnsWorker.IsBusy)
			{
				dnsWorker.CancelAsync();
			}

			while (dnsWorker.IsBusy)
			{
				Application.DoEvents();
			}

			dnsWorker.RunWorkerAsync((TextBox)sender);
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			if (traceWorker.IsBusy)
			{
				incrementValue = -1;
				traceWorker.CancelAsync();
			}
			else
			{
				this.Close();
			}
		}

		private void loadMap_Click(object sender, EventArgs e)
		{
			tracePb.Visible = true;
			loadMapBtn.Enabled = false;
			addressTb.Enabled = false;
			map.Enabled = false;
			cancelBtn.Text = "Cancel";
			incrementValue = 1;

			ResetMap();

			traceWorker.RunWorkerAsync(this.targetAddress);
			progressWorker.RunWorkerAsync();
		}

		private void dnsWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var tb = (TextBox)e.Argument;
			if (IsValidAddress(tb.Text, out targetAddress))
			{
				e.Result = true;
			}
			else
			{
				e.Result = false;
			}

		}

		private void dnsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if ((bool)e.Result)
			{
				addressTb.ForeColor = Color.Black;
				loadMapBtn.Enabled = true;
			}
			else
			{
				addressTb.ForeColor = Color.Red;
				loadMapBtn.Enabled = false;
			}
			addressLc.Visible = false;
			addressLc.Active = false;
		}

		private void progressWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (!progressWorker.CancellationPending)
			{
				if (tracePb.Value >= tracePb.Maximum && incrementValue == 1)
				{
					ResetProgressBar();
				}
				else if (tracePb.Value <= tracePb.Minimum && incrementValue == -1)
				{
					ResetProgressBar(100);
				}
				IncrementProgressBar(incrementValue);
				Thread.Sleep(7);
			}
			ResetProgressBar();
		}

		private void progressWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			ResetProgressBar();
		}

		private void traceWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			TraceRoute((IPAddress)e.Argument);
		}

		private void traceWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			progressWorker.CancelAsync();

			tracePb.Visible = false;
			map.Enabled = true;
			loadMapBtn.Enabled = true;
			addressTb.Enabled = true;
			cancelBtn.Text = "Exit";

			CenterMap("Points");
		}

		private void AddItem(ListViewItem item)
		{
			try
			{
				Invoke(new Action(() =>
				{
					traceInfoLv.Items.Add(item);
					traceInfoLv.Items[traceInfoLv.Items.Count - 1].EnsureVisible();
				}));
			}
			catch { }
		}

		private void CenterMap(String overlayId)
		{
			map.ZoomAndCenterMarkers(overlayId);
		}

		private void IncrementProgressBar(int value)
		{
			try
			{
				Invoke(new Action(() => { tracePb.Increment(value); }));
			}
			catch { }
		}

		private bool IsValidAddress(String target, out IPAddress ipAddress)
		{
			ipAddress = IPAddress.None;
			if (!IPAddress.TryParse(target, out ipAddress))
			{
				IPAddress[] hostAddressList = null;
				try
				{
					hostAddressList = Dns.GetHostAddresses(target);
				}
				catch (System.Net.Sockets.SocketException) { }

				if (hostAddressList != null)
				{
					ipAddress = hostAddressList[0];
					return true;
				}
			}
			return false;

		}

		private void ResetMap()
		{
			try
			{
				Invoke(new Action(() =>
					{
						traceInfoLv.Items.Clear();
						map.Overlays.Clear();
						pointOverlay.Markers.Clear();
						routeOverlay.Polygons.Clear();

						map.Position = new PointLatLng(0, 0);
						map.Zoom = map.MinZoom;
					}));
			}
			catch { }
		}

		private void ResetProgressBar(int value = 0)
		{
			Invoke(new Action(() => { tracePb.Value = value; }));
		}

		private void TraceRoute(IPAddress target)
		{
			var current = new PointLatLng(-1, -1);
			var last = new PointLatLng(-1, -1);
			var ipAddress = target;

			using (Ping pingSender = new Ping())
			{
				PingOptions pingOptions = new PingOptions();
				Stopwatch stopWatch = new Stopwatch();
				byte[] bytes = new byte[32];

				pingOptions.DontFragment = true;
				pingOptions.Ttl = 1;
				int maxHops = this.hopLimit;

				for (int i = 0; i < maxHops; i++)
				{
					if (!traceWorker.CancellationPending)
					{
						stopWatch.Reset();
						stopWatch.Start();
						PingReply pingReply = pingSender.Send(ipAddress, 5000, new byte[32], pingOptions);
						stopWatch.Stop();

						ListViewItem item = new ListViewItem((i + 1).ToString());

						try
						{
							if (pingReply.Status != IPStatus.TimedOut)
							{
								GeoIpData data;
								if (i == 0)
								{
									data = GeoIp.GetLocationData();
									item.SubItems.Add(Dns.GetHostName());
									item.SubItems.Add(pingReply.Address.ToString());
								}
								else
								{
									data = GeoIp.GetLocationData(pingReply.Address.ToString());
									item.SubItems.Add(data.Hostname);
									item.SubItems.Add(data.Ip.ToString());
								}
								item.SubItems.Add(stopWatch.ElapsedMilliseconds + "ms");
								item.SubItems.Add(data.Point.Lat.ToString());
								item.SubItems.Add(data.Point.Lng.ToString());
								item.SubItems.Add(data.City);
								item.SubItems.Add(data.Region);
								item.SubItems.Add(data.Country);

								current = data.Point;
								if (pingReply.Status == IPStatus.Success)
								{
									PlotPoint(data.Point, -1);
								}
								else
								{
									PlotPoint(data.Point, i + 1);
								}

								if (last.Lat != -1 && !current.Equals(last))
								{
									PlotRoute(last, current, stopWatch.ElapsedMilliseconds);
								}
							}
							else
							{
								item.SubItems.Add("-");
								item.SubItems.Add("Timeout");
								item.SubItems.Add("*");
								item.SubItems.Add("-");
								item.SubItems.Add("-");
								item.SubItems.Add("-");
								item.SubItems.Add("-");
								item.SubItems.Add("-");
							}
							AddItem(item);
						}
						catch { }
						//traceResults.AppendLine(string.Format("{0}\t{1} ms\t{2}", i, stopWatch.ElapsedMilliseconds, pingReply.Address));

						if (pingReply.Status == IPStatus.Success)
						{
							break;
						}
						last = current;
						pingOptions.Ttl++;
					}
					else
					{
						ResetMap();
						break;
					}
				}
			}
		}

		private void PlotPoint(PointLatLng current, int hop)
		{
			var marker = new GMap.NET.WindowsForms.Markers.GMapMarkerCross(current);
			var secondary = new GMap.NET.WindowsForms.Markers.GMapMarkerCross(current);
			marker.Pen.Color = Color.White;
			marker.Pen.Width = 1;
			secondary.Pen.Width = 3;
			if (hop == 1)
			{
				secondary.Pen.Color = Color.Lime;
				pointOverlay.Markers.Add(secondary);
				pointOverlay.Markers.Add(marker);
			}
			else if (hop == -1)
			{
				secondary.Pen.Color = Color.Red;
				pointOverlay.Markers.Add(secondary);
				pointOverlay.Markers.Add(marker);
			}
			else
			{
				secondary.Pen.Color = Color.SlateBlue;
				pointOverlay.Markers.Add(secondary);
				pointOverlay.Markers.Add(marker);
			}

			map.Overlays.Add(pointOverlay);
		}

		private void PlotRoute(PointLatLng start, PointLatLng end, long delay)
		{
			Color brushColor = Color.LimeGreen;
			if (delay > 100)
			{
				brushColor = Color.Crimson;
			}
			else if (delay > 75)
			{
				brushColor = Color.Gold;
			}
			List<PointLatLng> points = new List<PointLatLng>();
			points.Add(start);
			points.Add(end);
			GMapPolygon polygon = new GMapPolygon(points, "polygon");

			GPoint startTest = map.FromLatLngToLocal(start);
			GPoint endTest = map.FromLatLngToLocal(end);
			LinearGradientBrush gradient = new LinearGradientBrush(new Point(startTest.X, startTest.Y), new Point(endTest.X, endTest.Y), Color.LimeGreen, Color.LimeGreen);

			Pen pen = new Pen(gradient, 1f);


			polygon.Stroke = pen;

			routeOverlay.Polygons.Add(polygon);
			map.Overlays.Add(routeOverlay);
		}

	}
}
