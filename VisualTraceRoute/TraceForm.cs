﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Drawing2D;

//http://greatmaps.codeplex.com/

namespace VisualTraceRoute
{
	public partial class TraceForm : Form
	{
		private GMapOverlay pointOverlay;
		private GMapOverlay routeOverlay;
		private IPAddress targetAddress;
		private int hopLimit = 30;

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

		private void loadMap_Click(object sender, EventArgs e)
		{
			map.Enabled = false;
			traceInfoLv.Items.Clear();
			map.Overlays.Clear();
			pointOverlay.Markers.Clear();
			routeOverlay.Polygons.Clear();

			map.Position = new PointLatLng(0, 0);
			map.Zoom = map.MinZoom;

			CheckForIllegalCrossThreadCalls = true;
			Thread tracert = new Thread(() => TraceRoute(targetAddress));
			tracert.IsBackground = true;
			tracert.Start();
		}

		private void destinationTb_TextChanged(object sender, EventArgs e)
		{
			loadMapBtn.Enabled = false;
			loadingCircle.Visible = true;
			loadingCircle.Active = true;

			if (backgroundWorker.IsBusy)
			{
				backgroundWorker.CancelAsync();
			}

			while (backgroundWorker.IsBusy)
			{
				Application.DoEvents();
			}

			backgroundWorker.RunWorkerAsync((TextBox)sender);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
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

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if ((bool)e.Result)
			{
				targetTb.ForeColor = Color.Black;
				loadMapBtn.Enabled = true;
			}
			else
			{
				targetTb.ForeColor = Color.Red;
				loadMapBtn.Enabled = false;
			}
			loadingCircle.Visible = false;
			loadingCircle.Active = false;
		}

		private void AddItem(ListViewItem item)
		{
			Invoke(new Action(() =>
			{
				traceInfoLv.Items.Add(item);
				traceInfoLv.Items[traceInfoLv.Items.Count - 1].EnsureVisible();
			}));
		}

		private void CenterMap(String overlayId)
		{
			Invoke(new Action(() =>
			{
				map.ZoomAndCenterMarkers(overlayId);
				map.Enabled = true;
			}));
		}

		private bool IsValidAddress(String target, out IPAddress ipAddress)
		{
			ipAddress = IPAddress.None;
			if (!IPAddress.TryParse(target, out ipAddress))
			{
				IPAddress[] addresses = null;
				try
				{
					addresses = Dns.GetHostAddresses(target);
				}
				catch
				{

				}
				if (addresses != null)
				{
					ipAddress = addresses[0];
					return true;
				}

			}
			return false;

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
					stopWatch.Reset();
					stopWatch.Start();
					PingReply pingReply = pingSender.Send(ipAddress, 5000, new byte[32], pingOptions);
					stopWatch.Stop();

					ListViewItem item = new ListViewItem((i + 1).ToString());

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
						item.SubItems.Add("timed out");
						item.SubItems.Add("*");
						item.SubItems.Add("-");
						item.SubItems.Add("-");
						item.SubItems.Add("-");
						item.SubItems.Add("-");
						item.SubItems.Add("-");
					}
					AddItem(item);
					//traceResults.AppendLine(string.Format("{0}\t{1} ms\t{2}", i, stopWatch.ElapsedMilliseconds, pingReply.Address));

					if (pingReply.Status == IPStatus.Success)
					{
						break;
					}
					last = current;
					pingOptions.Ttl++;
				}
			}
			CenterMap("Points");
			//return traceResults.ToString();
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