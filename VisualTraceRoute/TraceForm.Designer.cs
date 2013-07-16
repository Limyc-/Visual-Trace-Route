namespace VisualTraceRoute
{
	partial class TraceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.map = new GMap.NET.WindowsForms.GMapControl();
			this.loadMapBtn = new System.Windows.Forms.Button();
			this.traceInfoLv = new System.Windows.Forms.ListView();
			this.hop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ipAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.delay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.targetTb = new System.Windows.Forms.TextBox();
			this.destinationLbl = new System.Windows.Forms.Label();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.addressLC = new MRG.Controls.UI.LoadingCircle();
			this.mapLC = new MRG.Controls.UI.LoadingCircle();
			this.SuspendLayout();
			// 
			// map
			// 
			this.map.Bearing = 0F;
			this.map.CanDragMap = true;
			this.map.Cursor = System.Windows.Forms.Cursors.Default;
			this.map.Dock = System.Windows.Forms.DockStyle.Top;
			this.map.GrayScaleMode = false;
			this.map.LevelsKeepInMemmory = 5;
			this.map.Location = new System.Drawing.Point(0, 0);
			this.map.MarkersEnabled = true;
			this.map.MaxZoom = 17;
			this.map.MinZoom = 2;
			this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
			this.map.Name = "map";
			this.map.NegativeMode = false;
			this.map.PolygonsEnabled = true;
			this.map.RetryLoadTile = 0;
			this.map.RoutesEnabled = true;
			this.map.ShowTileGridLines = false;
			this.map.Size = new System.Drawing.Size(800, 494);
			this.map.TabIndex = 0;
			this.map.Zoom = 2D;
			this.map.Load += new System.EventHandler(this.map_Load);
			// 
			// loadMapBtn
			// 
			this.loadMapBtn.Enabled = false;
			this.loadMapBtn.Location = new System.Drawing.Point(669, 700);
			this.loadMapBtn.Name = "loadMapBtn";
			this.loadMapBtn.Size = new System.Drawing.Size(119, 28);
			this.loadMapBtn.TabIndex = 2;
			this.loadMapBtn.Text = "Load Map";
			this.loadMapBtn.UseVisualStyleBackColor = true;
			this.loadMapBtn.Click += new System.EventHandler(this.loadMap_Click);
			// 
			// traceInfoLv
			// 
			this.traceInfoLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hop,
            this.hostName,
            this.ipAddress,
            this.delay,
            this.latitude,
            this.longitude,
            this.city,
            this.region,
            this.country});
			this.traceInfoLv.FullRowSelect = true;
			this.traceInfoLv.GridLines = true;
			this.traceInfoLv.LabelWrap = false;
			this.traceInfoLv.Location = new System.Drawing.Point(0, 494);
			this.traceInfoLv.Name = "traceInfoLv";
			this.traceInfoLv.Size = new System.Drawing.Size(800, 200);
			this.traceInfoLv.TabIndex = 4;
			this.traceInfoLv.TileSize = new System.Drawing.Size(150, 30);
			this.traceInfoLv.UseCompatibleStateImageBehavior = false;
			this.traceInfoLv.View = System.Windows.Forms.View.Details;
			// 
			// hop
			// 
			this.hop.Text = "Hop";
			this.hop.Width = 32;
			// 
			// hostName
			// 
			this.hostName.Text = "Host Name";
			this.hostName.Width = 180;
			// 
			// ipAddress
			// 
			this.ipAddress.Text = "IP Address";
			this.ipAddress.Width = 90;
			// 
			// delay
			// 
			this.delay.Text = "Delay";
			this.delay.Width = 40;
			// 
			// latitude
			// 
			this.latitude.Text = "Latitude";
			// 
			// longitude
			// 
			this.longitude.Text = "Longitude";
			// 
			// city
			// 
			this.city.Text = "City";
			this.city.Width = 110;
			// 
			// region
			// 
			this.region.Text = "Region";
			this.region.Width = 100;
			// 
			// country
			// 
			this.country.Text = "Country";
			this.country.Width = 106;
			// 
			// targetTb
			// 
			this.targetTb.Location = new System.Drawing.Point(139, 705);
			this.targetTb.Name = "targetTb";
			this.targetTb.Size = new System.Drawing.Size(497, 20);
			this.targetTb.TabIndex = 5;
			this.targetTb.TextChanged += new System.EventHandler(this.destinationTb_TextChanged);
			// 
			// destinationLbl
			// 
			this.destinationLbl.AutoSize = true;
			this.destinationLbl.Location = new System.Drawing.Point(12, 708);
			this.destinationLbl.Name = "destinationLbl";
			this.destinationLbl.Size = new System.Drawing.Size(121, 13);
			this.destinationLbl.TabIndex = 6;
			this.destinationLbl.Text = "Hostname or IP Address";
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// addressLC
			// 
			this.addressLC.Active = false;
			this.addressLC.Color = System.Drawing.Color.DarkGray;
			this.addressLC.InnerCircleRadius = 6;
			this.addressLC.Location = new System.Drawing.Point(642, 705);
			this.addressLC.Name = "addressLC";
			this.addressLC.NumberSpoke = 9;
			this.addressLC.OuterCircleRadius = 7;
			this.addressLC.RotationSpeed = 100;
			this.addressLC.Size = new System.Drawing.Size(21, 20);
			this.addressLC.SpokeThickness = 4;
			this.addressLC.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.Firefox;
			this.addressLC.TabIndex = 7;
			this.addressLC.Text = "loadingCircle";
			this.addressLC.Visible = false;
			// 
			// mapLC
			// 
			this.mapLC.Active = false;
			this.mapLC.BackColor = System.Drawing.Color.Transparent;
			this.mapLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.mapLC.Color = System.Drawing.Color.DarkGray;
			this.mapLC.InnerCircleRadius = 12;
			this.mapLC.Location = new System.Drawing.Point(750, 453);
			this.mapLC.Name = "mapLC";
			this.mapLC.NumberSpoke = 9;
			this.mapLC.OuterCircleRadius = 14;
			this.mapLC.RotationSpeed = 100;
			this.mapLC.Size = new System.Drawing.Size(50, 41);
			this.mapLC.SpokeThickness = 8;
			this.mapLC.TabIndex = 8;
			this.mapLC.Text = "mapLC";
			this.mapLC.Visible = false;
			// 
			// TraceForm
			// 
			this.AcceptButton = this.loadMapBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 732);
			this.Controls.Add(this.mapLC);
			this.Controls.Add(this.addressLC);
			this.Controls.Add(this.destinationLbl);
			this.Controls.Add(this.targetTb);
			this.Controls.Add(this.traceInfoLv);
			this.Controls.Add(this.loadMapBtn);
			this.Controls.Add(this.map);
			this.Name = "TraceForm";
			this.Text = "Visual Trace Route";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl map;
		private System.Windows.Forms.Button loadMapBtn;
		private System.Windows.Forms.ListView traceInfoLv;
		private System.Windows.Forms.ColumnHeader hop;
		private System.Windows.Forms.ColumnHeader hostName;
		private System.Windows.Forms.ColumnHeader ipAddress;
		private System.Windows.Forms.ColumnHeader delay;
		private System.Windows.Forms.ColumnHeader latitude;
		private System.Windows.Forms.ColumnHeader longitude;
		private System.Windows.Forms.ColumnHeader city;
		private System.Windows.Forms.ColumnHeader region;
		private System.Windows.Forms.ColumnHeader country;
		private System.Windows.Forms.TextBox targetTb;
		private System.Windows.Forms.Label destinationLbl;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private MRG.Controls.UI.LoadingCircle addressLC;
		private MRG.Controls.UI.LoadingCircle mapLC;
	}
}

