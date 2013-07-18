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
			this.loadMapButton = new System.Windows.Forms.Button();
			this.traceInfoListView = new System.Windows.Forms.ListView();
			this.hop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ipAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.delay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.destinationLabel = new System.Windows.Forms.Label();
			this.dnsWorker = new System.ComponentModel.BackgroundWorker();
			this.addressLoadingCircle = new MRG.Controls.UI.LoadingCircle();
			this.traceWorker = new System.ComponentModel.BackgroundWorker();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.traceProgressBar = new System.Windows.Forms.ProgressBar();
			this.progressWorker = new System.ComponentModel.BackgroundWorker();
			this.innerSplitContainer = new System.Windows.Forms.SplitContainer();
			this.outerSplitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.innerSplitContainer)).BeginInit();
			this.innerSplitContainer.Panel1.SuspendLayout();
			this.innerSplitContainer.Panel2.SuspendLayout();
			this.innerSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.outerSplitContainer)).BeginInit();
			this.outerSplitContainer.Panel1.SuspendLayout();
			this.outerSplitContainer.Panel2.SuspendLayout();
			this.outerSplitContainer.SuspendLayout();
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
			// loadMapButton
			// 
			this.loadMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.loadMapButton.Enabled = false;
			this.loadMapButton.Location = new System.Drawing.Point(450, -1);
			this.loadMapButton.Name = "loadMapButton";
			this.loadMapButton.Size = new System.Drawing.Size(119, 28);
			this.loadMapButton.TabIndex = 2;
			this.loadMapButton.Text = "Load Map";
			this.loadMapButton.UseVisualStyleBackColor = true;
			this.loadMapButton.Click += new System.EventHandler(this.loadMap_Click);
			// 
			// traceInfoListView
			// 
			this.traceInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hop,
            this.hostName,
            this.ipAddress,
            this.delay,
            this.latitude,
            this.longitude,
            this.city,
            this.region,
            this.country});
			this.traceInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.traceInfoListView.FullRowSelect = true;
			this.traceInfoListView.GridLines = true;
			this.traceInfoListView.LabelWrap = false;
			this.traceInfoListView.Location = new System.Drawing.Point(0, 0);
			this.traceInfoListView.Name = "traceInfoListView";
			this.traceInfoListView.Size = new System.Drawing.Size(706, 133);
			this.traceInfoListView.TabIndex = 4;
			this.traceInfoListView.TileSize = new System.Drawing.Size(150, 30);
			this.traceInfoListView.UseCompatibleStateImageBehavior = false;
			this.traceInfoListView.View = System.Windows.Forms.View.Details;
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
			// addressTextBox
			// 
			this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.addressTextBox.Location = new System.Drawing.Point(139, 4);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(278, 20);
			this.addressTextBox.TabIndex = 5;
			this.addressTextBox.WordWrap = false;
			this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
			// 
			// destinationLabel
			// 
			this.destinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.destinationLabel.AutoSize = true;
			this.destinationLabel.Location = new System.Drawing.Point(12, 7);
			this.destinationLabel.Name = "destinationLabel";
			this.destinationLabel.Size = new System.Drawing.Size(121, 13);
			this.destinationLabel.TabIndex = 6;
			this.destinationLabel.Text = "Hostname or IP Address";
			// 
			// dnsWorker
			// 
			this.dnsWorker.WorkerSupportsCancellation = true;
			this.dnsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dnsWorker_DoWork);
			this.dnsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dnsWorker_RunWorkerCompleted);
			// 
			// addressLoadingCircle
			// 
			this.addressLoadingCircle.Active = false;
			this.addressLoadingCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addressLoadingCircle.Color = System.Drawing.Color.DarkGray;
			this.addressLoadingCircle.InnerCircleRadius = 6;
			this.addressLoadingCircle.Location = new System.Drawing.Point(423, 4);
			this.addressLoadingCircle.Name = "addressLoadingCircle";
			this.addressLoadingCircle.NumberSpoke = 9;
			this.addressLoadingCircle.OuterCircleRadius = 7;
			this.addressLoadingCircle.RotationSpeed = 100;
			this.addressLoadingCircle.Size = new System.Drawing.Size(21, 20);
			this.addressLoadingCircle.SpokeThickness = 4;
			this.addressLoadingCircle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.Firefox;
			this.addressLoadingCircle.TabIndex = 7;
			this.addressLoadingCircle.Text = "loadingCircle";
			this.addressLoadingCircle.Visible = false;
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
			this.cancelBtn.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// traceProgressBar
			// 
			this.traceProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.traceProgressBar.Location = new System.Drawing.Point(519, 334);
			this.traceProgressBar.MarqueeAnimationSpeed = 50;
			this.traceProgressBar.Name = "traceProgressBar";
			this.traceProgressBar.Size = new System.Drawing.Size(175, 23);
			this.traceProgressBar.TabIndex = 10;
			this.traceProgressBar.Visible = false;
			// 
			// progressWorker
			// 
			this.progressWorker.WorkerSupportsCancellation = true;
			this.progressWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressWorker_DoWork);
			this.progressWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressWorker_RunWorkerCompleted);
			// 
			// innerSplitContainer
			// 
			this.innerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.innerSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.innerSplitContainer.Name = "innerSplitContainer";
			this.innerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// innerSplitContainer.Panel1
			// 
			this.innerSplitContainer.Panel1.Controls.Add(this.traceProgressBar);
			this.innerSplitContainer.Panel1.Controls.Add(this.map);
			// 
			// innerSplitContainer.Panel2
			// 
			this.innerSplitContainer.Panel2.AutoScroll = true;
			this.innerSplitContainer.Panel2.Controls.Add(this.traceInfoListView);
			this.innerSplitContainer.Panel2MinSize = 70;
			this.innerSplitContainer.Size = new System.Drawing.Size(706, 497);
			this.innerSplitContainer.SplitterDistance = 360;
			this.innerSplitContainer.TabIndex = 12;
			// 
			// outerSplitContainer
			// 
			this.outerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerSplitContainer.IsSplitterFixed = true;
			this.outerSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.outerSplitContainer.Name = "outerSplitContainer";
			this.outerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// outerSplitContainer.Panel1
			// 
			this.outerSplitContainer.Panel1.Controls.Add(this.innerSplitContainer);
			// 
			// outerSplitContainer.Panel2
			// 
			this.outerSplitContainer.Panel2.Controls.Add(this.addressTextBox);
			this.outerSplitContainer.Panel2.Controls.Add(this.cancelBtn);
			this.outerSplitContainer.Panel2.Controls.Add(this.addressLoadingCircle);
			this.outerSplitContainer.Panel2.Controls.Add(this.destinationLabel);
			this.outerSplitContainer.Panel2.Controls.Add(this.loadMapButton);
			this.outerSplitContainer.Panel2MinSize = 30;
			this.outerSplitContainer.Size = new System.Drawing.Size(706, 531);
			this.outerSplitContainer.SplitterDistance = 497;
			this.outerSplitContainer.TabIndex = 13;
			// 
			// TraceForm
			// 
			this.AcceptButton = this.loadMapButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(706, 531);
			this.Controls.Add(this.outerSplitContainer);
			this.MinimumSize = new System.Drawing.Size(513, 38);
			this.Name = "TraceForm";
			this.Text = "Visual Trace Route";
			this.Load += new System.EventHandler(this.TraceForm_Load);
			this.Resize += new System.EventHandler(this.TraceForm_Resize);
			this.innerSplitContainer.Panel1.ResumeLayout(false);
			this.innerSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.innerSplitContainer)).EndInit();
			this.innerSplitContainer.ResumeLayout(false);
			this.outerSplitContainer.Panel1.ResumeLayout(false);
			this.outerSplitContainer.Panel2.ResumeLayout(false);
			this.outerSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.outerSplitContainer)).EndInit();
			this.outerSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl map;
		private System.Windows.Forms.Button loadMapButton;
		private System.Windows.Forms.ListView traceInfoListView;
		private System.Windows.Forms.ColumnHeader hop;
		private System.Windows.Forms.ColumnHeader hostName;
		private System.Windows.Forms.ColumnHeader ipAddress;
		private System.Windows.Forms.ColumnHeader delay;
		private System.Windows.Forms.ColumnHeader latitude;
		private System.Windows.Forms.ColumnHeader longitude;
		private System.Windows.Forms.ColumnHeader city;
		private System.Windows.Forms.ColumnHeader region;
		private System.Windows.Forms.ColumnHeader country;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label destinationLabel;
		private System.ComponentModel.BackgroundWorker dnsWorker;
		private MRG.Controls.UI.LoadingCircle addressLoadingCircle;
		private System.ComponentModel.BackgroundWorker traceWorker;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ProgressBar traceProgressBar;
		private System.ComponentModel.BackgroundWorker progressWorker;
		private System.Windows.Forms.SplitContainer innerSplitContainer;
		private System.Windows.Forms.SplitContainer outerSplitContainer;
	}
}

