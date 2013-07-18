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
			this.addressTb = new System.Windows.Forms.TextBox();
			this.destinationLbl = new System.Windows.Forms.Label();
			this.dnsWorker = new System.ComponentModel.BackgroundWorker();
			this.addressLc = new MRG.Controls.UI.LoadingCircle();
			this.traceWorker = new System.ComponentModel.BackgroundWorker();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.tracePb = new System.Windows.Forms.ProgressBar();
			this.progressWorker = new System.ComponentModel.BackgroundWorker();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// map
			// 
			this.map.Bearing = 0F;
			this.map.CanDragMap = true;
			this.map.Cursor = System.Windows.Forms.Cursors.Default;
			this.map.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.map.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.map.RoutesEnabled = true;
			this.map.ShowTileGridLines = false;
			this.map.Size = new System.Drawing.Size(706, 360);
			this.map.TabIndex = 0;
			this.map.Zoom = 2D;
			this.map.Load += new System.EventHandler(this.map_Load);
			// 
			// loadMapBtn
			// 
			this.loadMapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.loadMapBtn.Enabled = false;
			this.loadMapBtn.Location = new System.Drawing.Point(450, -1);
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
			this.traceInfoLv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.traceInfoLv.FullRowSelect = true;
			this.traceInfoLv.GridLines = true;
			this.traceInfoLv.LabelWrap = false;
			this.traceInfoLv.Location = new System.Drawing.Point(0, 0);
			this.traceInfoLv.Name = "traceInfoLv";
			this.traceInfoLv.Size = new System.Drawing.Size(706, 133);
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
			this.hostName.Width = 139;
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
			this.city.Width = 88;
			// 
			// region
			// 
			this.region.Text = "Region";
			this.region.Width = 88;
			// 
			// country
			// 
			this.country.Text = "Country";
			this.country.Width = 88;
			// 
			// addressTb
			// 
			this.addressTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addressTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.addressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.addressTb.Location = new System.Drawing.Point(139, 4);
			this.addressTb.Name = "addressTb";
			this.addressTb.Size = new System.Drawing.Size(278, 20);
			this.addressTb.TabIndex = 5;
			this.addressTb.WordWrap = false;
			this.addressTb.TextChanged += new System.EventHandler(this.addressTb_TextChanged);
			// 
			// destinationLbl
			// 
			this.destinationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.destinationLbl.AutoSize = true;
			this.destinationLbl.Location = new System.Drawing.Point(12, 7);
			this.destinationLbl.Name = "destinationLbl";
			this.destinationLbl.Size = new System.Drawing.Size(121, 13);
			this.destinationLbl.TabIndex = 6;
			this.destinationLbl.Text = "Hostname or IP Address";
			// 
			// dnsWorker
			// 
			this.dnsWorker.WorkerSupportsCancellation = true;
			this.dnsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dnsWorker_DoWork);
			this.dnsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dnsWorker_RunWorkerCompleted);
			// 
			// addressLc
			// 
			this.addressLc.Active = false;
			this.addressLc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addressLc.Color = System.Drawing.Color.DarkGray;
			this.addressLc.InnerCircleRadius = 6;
			this.addressLc.Location = new System.Drawing.Point(423, 4);
			this.addressLc.Name = "addressLc";
			this.addressLc.NumberSpoke = 9;
			this.addressLc.OuterCircleRadius = 7;
			this.addressLc.RotationSpeed = 100;
			this.addressLc.Size = new System.Drawing.Size(21, 20);
			this.addressLc.SpokeThickness = 4;
			this.addressLc.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.Firefox;
			this.addressLc.TabIndex = 7;
			this.addressLc.Text = "loadingCircle";
			this.addressLc.Visible = false;
			// 
			// traceWorker
			// 
			this.traceWorker.WorkerSupportsCancellation = true;
			this.traceWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.traceWorker_DoWork);
			this.traceWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.traceWorker_RunWorkerCompleted);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(575, -1);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(119, 28);
			this.cancelBtn.TabIndex = 9;
			this.cancelBtn.Text = "Exit";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// tracePb
			// 
			this.tracePb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tracePb.Location = new System.Drawing.Point(519, 334);
			this.tracePb.MarqueeAnimationSpeed = 50;
			this.tracePb.Name = "tracePb";
			this.tracePb.Size = new System.Drawing.Size(175, 23);
			this.tracePb.TabIndex = 10;
			this.tracePb.Visible = false;
			// 
			// progressWorker
			// 
			this.progressWorker.WorkerSupportsCancellation = true;
			this.progressWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressWorker_DoWork);
			this.progressWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressWorker_RunWorkerCompleted);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tracePb);
			this.splitContainer1.Panel1.Controls.Add(this.map);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AutoScroll = true;
			this.splitContainer1.Panel2.Controls.Add(this.traceInfoLv);
			this.splitContainer1.Panel2MinSize = 70;
			this.splitContainer1.Size = new System.Drawing.Size(706, 497);
			this.splitContainer1.SplitterDistance = 360;
			this.splitContainer1.TabIndex = 12;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.addressTb);
			this.splitContainer2.Panel2.Controls.Add(this.cancelBtn);
			this.splitContainer2.Panel2.Controls.Add(this.addressLc);
			this.splitContainer2.Panel2.Controls.Add(this.destinationLbl);
			this.splitContainer2.Panel2.Controls.Add(this.loadMapBtn);
			this.splitContainer2.Panel2MinSize = 30;
			this.splitContainer2.Size = new System.Drawing.Size(706, 531);
			this.splitContainer2.SplitterDistance = 497;
			this.splitContainer2.TabIndex = 13;
			// 
			// TraceForm
			// 
			this.AcceptButton = this.loadMapBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(706, 531);
			this.Controls.Add(this.splitContainer2);
			this.MinimumSize = new System.Drawing.Size(513, 38);
			this.Name = "TraceForm";
			this.Text = "Visual Trace Route";
			this.Resize += new System.EventHandler(this.TraceForm_Resize);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

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
		private System.Windows.Forms.TextBox addressTb;
		private System.Windows.Forms.Label destinationLbl;
		private System.ComponentModel.BackgroundWorker dnsWorker;
		private MRG.Controls.UI.LoadingCircle addressLc;
		private System.ComponentModel.BackgroundWorker traceWorker;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ProgressBar tracePb;
		private System.ComponentModel.BackgroundWorker progressWorker;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
	}
}

