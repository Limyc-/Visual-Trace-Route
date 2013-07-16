using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GMap.NET;

namespace VisualTraceRoute
{
	class GeoIpData
	{
		private IPAddress ip;
		private String hostname;
		private String country;
		private String region;
		private String city;
		private PointLatLng point;
		
		public IPAddress Ip
		{
			get { return ip; }
			set { ip = value; }
		}
		public String Hostname
		{
			get { return hostname; }
			set { hostname = value; }
		}
		public String Country
		{
			get { return country; }
			set { country = value; }
		}
		public String Region
		{
			get { return region; }
			set { region = value; }
		}
		public String City
		{
			get { return city; }
			set { city = value; }
		}
		public PointLatLng Point
		{
			get { return point; }
			set { point = value; }
		}

		public GeoIpData() : this(IPAddress.Parse("10.0.0.1"), "local", "Country", "Region", "City", new PointLatLng()) { }

		public GeoIpData(IPAddress ip, String hostname, String country, String region, String city, PointLatLng point)
		{
			this.ip = ip;
			this.hostname = hostname;
			this.country = country;
			this.region = region;
			this.city = city;
			this.point = point;
		}

	}
}
