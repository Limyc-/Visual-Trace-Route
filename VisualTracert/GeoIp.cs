using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using GMap.NET;
using System.Globalization;

//URL: http://api.ipinfodb.com
//API Key: 455fab53034fe3e36a62063dba8910b8d907f0f8b673f2b3ad5ac496aa73dad9

namespace VisualTraceRoute
{
	class GeoIp
	{
		private static String apiKey = "455fab53034fe3e36a62063dba8910b8d907f0f8b673f2b3ad5ac496aa73dad9";

		public static GeoIpData GetLocationData(String ipAddressOrHostname = "")
		{
			String ip = "";
			if (ipAddressOrHostname != "")
			{
				ip = "&ip=" + ipAddressOrHostname;
			}
			String url = @"http://api.ipinfodb.com/v3/ip-city/?key=" + apiKey + ip + @"&format=xml";
			WebClient wc = new WebClient();
			wc.Proxy = null;
			GeoIpData geoData;
			XmlDocument xDoc;
			double lat = 0.0, lng = 0.0;

			using (MemoryStream ms = new MemoryStream(wc.DownloadData(url)))
			using (XmlTextReader reader = new XmlTextReader(url))
			{
				xDoc = new XmlDocument();
				ms.Position = 0;
				xDoc.Load(ms);
				ms.Dispose();
				geoData = new GeoIpData();
				TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
				foreach (XmlElement element in xDoc.ChildNodes[1].ChildNodes)
				{
					switch (element.Name)
					{
						case "ipAddress":
							geoData.Ip = IPAddress.Parse(element.InnerText);
							geoData.Hostname = GetHostname(geoData.Ip);
							break;
						case "countryName":
							geoData.Country = ti.ToTitleCase(element.InnerText.ToLower());
							break;
						case "regionName":
							geoData.Region = ti.ToTitleCase(element.InnerText.ToLower());
							break;
						case "cityName":
							geoData.City = ti.ToTitleCase(element.InnerText.ToLower());
							break;
						case "latitude":
							lat = Convert.ToDouble(element.InnerText);
							break;
						case "longitude":
							lng = Convert.ToDouble(element.InnerText);
							break;
					}
				}
				geoData.Point = new PointLatLng(lat, lng);
			}

			return geoData;
		}

		private static String GetHostname(IPAddress ipAddress)
		{
			try
			{
				String hostname = Dns.GetHostEntry(ipAddress).HostName;
				return hostname;
			}
			catch
			{
				return ipAddress.ToString();
			}
		}
	}
}
