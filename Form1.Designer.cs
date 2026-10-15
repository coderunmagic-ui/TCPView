namespace TCPView {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			dataGridView1 = new DataGridView();
			Icon1 = new DataGridViewImageColumn();
			ProcessName1 = new DataGridViewTextBoxColumn();
			ProcessId1 = new DataGridViewTextBoxColumn();
			LocalAddress1 = new DataGridViewTextBoxColumn();
			LocalPort1 = new DataGridViewTextBoxColumn();
			RemoteAddress1 = new DataGridViewTextBoxColumn();
			RemotePort1 = new DataGridViewTextBoxColumn();
			State1 = new DataGridViewTextBoxColumn();
			ApplicationPath1 = new DataGridViewTextBoxColumn();
			contextMenuStrip1 = new ContextMenuStrip(components);
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripMenuItem2 = new ToolStripMenuItem();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			dataGridView2 = new DataGridView();
			Icon2 = new DataGridViewImageColumn();
			ProcessName2 = new DataGridViewTextBoxColumn();
			ProcessId2 = new DataGridViewTextBoxColumn();
			LocalAddress2 = new DataGridViewTextBoxColumn();
			LocalPort2 = new DataGridViewTextBoxColumn();
			RemoteAddress2 = new DataGridViewTextBoxColumn();
			RemotePort2 = new DataGridViewTextBoxColumn();
			State2 = new DataGridViewTextBoxColumn();
			ApplicationPath2 = new DataGridViewTextBoxColumn();
			tabPage3 = new TabPage();
			dataGridView3 = new DataGridView();
			Icon3 = new DataGridViewImageColumn();
			ProcessName3 = new DataGridViewTextBoxColumn();
			ProcessId3 = new DataGridViewTextBoxColumn();
			LocalAddress3 = new DataGridViewTextBoxColumn();
			LocalPort3 = new DataGridViewTextBoxColumn();
			RemoteAddress3 = new DataGridViewTextBoxColumn();
			RemotePort3 = new DataGridViewTextBoxColumn();
			State3 = new DataGridViewTextBoxColumn();
			ApplicationPath3 = new DataGridViewTextBoxColumn();
			tabPage4 = new TabPage();
			dataGridView4 = new DataGridView();
			Icon4 = new DataGridViewImageColumn();
			ProcessName4 = new DataGridViewTextBoxColumn();
			ProcessId4 = new DataGridViewTextBoxColumn();
			LocalAddress4 = new DataGridViewTextBoxColumn();
			LocalPort4 = new DataGridViewTextBoxColumn();
			RemoteAddress4 = new DataGridViewTextBoxColumn();
			RemotePort4 = new DataGridViewTextBoxColumn();
			State4 = new DataGridViewTextBoxColumn();
			ApplicationPath4 = new DataGridViewTextBoxColumn();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolStripStatusLabel4 = new ToolStripStatusLabel();
			toolStripStatusLabel5 = new ToolStripStatusLabel();
			toolStripStatusLabel6 = new ToolStripStatusLabel();
			panel1 = new Panel();
			searchBox = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			contextMenuStrip1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
			statusStrip1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Icon1,ProcessName1,ProcessId1,LocalAddress1,LocalPort1,RemoteAddress1,RemotePort1,State1,ApplicationPath1 });
			dataGridView1.ContextMenuStrip = contextMenuStrip1;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3,3);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1170,565);
			dataGridView1.TabIndex = 0;
			dataGridView1.TabStop = false;
			// 
			// Icon1
			// 
			Icon1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Icon1.FillWeight = 50F;
			Icon1.HeaderText = "圖示";
			Icon1.ImageLayout = DataGridViewImageCellLayout.Zoom;
			Icon1.Name = "Icon1";
			Icon1.Resizable = DataGridViewTriState.True;
			Icon1.SortMode = DataGridViewColumnSortMode.Automatic;
			Icon1.ToolTipText = "圖示";
			Icon1.Width = 50;
			// 
			// ProcessName1
			// 
			ProcessName1.HeaderText = "進程檔名";
			ProcessName1.Name = "ProcessName1";
			ProcessName1.ToolTipText = "進程檔名";
			// 
			// ProcessId1
			// 
			ProcessId1.HeaderText = "進程pid";
			ProcessId1.Name = "ProcessId1";
			ProcessId1.ToolTipText = "進程pid";
			// 
			// LocalAddress1
			// 
			LocalAddress1.FillWeight = 200F;
			LocalAddress1.HeaderText = "本機位址";
			LocalAddress1.Name = "LocalAddress1";
			LocalAddress1.ToolTipText = "本機位址";
			LocalAddress1.Width = 200;
			// 
			// LocalPort1
			// 
			LocalPort1.HeaderText = "本機埠";
			LocalPort1.Name = "LocalPort1";
			LocalPort1.ToolTipText = "本機埠";
			// 
			// RemoteAddress1
			// 
			RemoteAddress1.FillWeight = 200F;
			RemoteAddress1.HeaderText = "遠端位址";
			RemoteAddress1.Name = "RemoteAddress1";
			RemoteAddress1.ToolTipText = "遠端位址";
			RemoteAddress1.Width = 200;
			// 
			// RemotePort1
			// 
			RemotePort1.HeaderText = "遠端埠";
			RemotePort1.Name = "RemotePort1";
			RemotePort1.ToolTipText = "遠端埠";
			// 
			// State1
			// 
			State1.HeaderText = "狀態";
			State1.Name = "State1";
			State1.ToolTipText = "狀態";
			// 
			// ApplicationPath1
			// 
			ApplicationPath1.FillWeight = 300F;
			ApplicationPath1.HeaderText = "應用程式路徑";
			ApplicationPath1.Name = "ApplicationPath1";
			ApplicationPath1.ToolTipText = "應用程式路徑";
			ApplicationPath1.Width = 300;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1,toolStripSeparator1,toolStripMenuItem2 });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.ShowImageMargin = false;
			contextMenuStrip1.Size = new Size(98,54);
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(97,22);
			toolStripMenuItem1.Text = "進程移除";
			toolStripMenuItem1.ToolTipText = "進程移除";
			toolStripMenuItem1.Click += toolStripMenuItem1_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(94,6);
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(97,22);
			toolStripMenuItem2.Text = "復製";
			toolStripMenuItem2.ToolTipText = "復製";
			toolStripMenuItem2.Click += toolStripMenuItem2_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0,40);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1184,599);
			tabControl1.TabIndex = 1;
			tabControl1.TabStop = false;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Location = new Point(4,24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1176,571);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "TCPV4";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Location = new Point(4,24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1176,571);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "TCPV6";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			dataGridView2.BackgroundColor = Color.White;
			dataGridView2.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Icon2,ProcessName2,ProcessId2,LocalAddress2,LocalPort2,RemoteAddress2,RemotePort2,State2,ApplicationPath2 });
			dataGridView2.ContextMenuStrip = contextMenuStrip1;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
			dataGridView2.Dock = DockStyle.Fill;
			dataGridView2.Location = new Point(3,3);
			dataGridView2.MultiSelect = false;
			dataGridView2.Name = "dataGridView2";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView2.RowHeadersVisible = false;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.Size = new Size(1170,565);
			dataGridView2.TabIndex = 1;
			dataGridView2.TabStop = false;
			// 
			// Icon2
			// 
			Icon2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Icon2.FillWeight = 50F;
			Icon2.HeaderText = "圖示";
			Icon2.ImageLayout = DataGridViewImageCellLayout.Zoom;
			Icon2.Name = "Icon2";
			Icon2.Resizable = DataGridViewTriState.True;
			Icon2.SortMode = DataGridViewColumnSortMode.Automatic;
			Icon2.ToolTipText = "圖示";
			Icon2.Width = 50;
			// 
			// ProcessName2
			// 
			ProcessName2.HeaderText = "進程檔名";
			ProcessName2.Name = "ProcessName2";
			ProcessName2.ToolTipText = "進程檔名";
			// 
			// ProcessId2
			// 
			ProcessId2.HeaderText = "進程pid";
			ProcessId2.Name = "ProcessId2";
			ProcessId2.ToolTipText = "進程pid";
			// 
			// LocalAddress2
			// 
			LocalAddress2.FillWeight = 200F;
			LocalAddress2.HeaderText = "本機位址";
			LocalAddress2.Name = "LocalAddress2";
			LocalAddress2.ToolTipText = "本機位址";
			LocalAddress2.Width = 200;
			// 
			// LocalPort2
			// 
			LocalPort2.HeaderText = "本機埠";
			LocalPort2.Name = "LocalPort2";
			LocalPort2.ToolTipText = "本機埠";
			// 
			// RemoteAddress2
			// 
			RemoteAddress2.FillWeight = 200F;
			RemoteAddress2.HeaderText = "遠端位址";
			RemoteAddress2.Name = "RemoteAddress2";
			RemoteAddress2.ToolTipText = "遠端位址";
			RemoteAddress2.Width = 200;
			// 
			// RemotePort2
			// 
			RemotePort2.HeaderText = "遠端埠";
			RemotePort2.Name = "RemotePort2";
			RemotePort2.ToolTipText = "遠端埠";
			// 
			// State2
			// 
			State2.HeaderText = "狀態";
			State2.Name = "State2";
			State2.ToolTipText = "狀態";
			// 
			// ApplicationPath2
			// 
			ApplicationPath2.FillWeight = 300F;
			ApplicationPath2.HeaderText = "應用程式路徑";
			ApplicationPath2.Name = "ApplicationPath2";
			ApplicationPath2.ToolTipText = "應用程式路徑";
			ApplicationPath2.Width = 300;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(dataGridView3);
			tabPage3.Location = new Point(4,24);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(1176,571);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "UDPV4";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			dataGridView3.AllowUserToAddRows = false;
			dataGridView3.AllowUserToResizeColumns = false;
			dataGridView3.AllowUserToResizeRows = false;
			dataGridView3.BackgroundColor = Color.White;
			dataGridView3.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Icon3,ProcessName3,ProcessId3,LocalAddress3,LocalPort3,RemoteAddress3,RemotePort3,State3,ApplicationPath3 });
			dataGridView3.ContextMenuStrip = contextMenuStrip1;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			dataGridView3.DefaultCellStyle = dataGridViewCellStyle8;
			dataGridView3.Dock = DockStyle.Fill;
			dataGridView3.Location = new Point(3,3);
			dataGridView3.MultiSelect = false;
			dataGridView3.Name = "dataGridView3";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridView3.RowHeadersVisible = false;
			dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView3.Size = new Size(1170,565);
			dataGridView3.TabIndex = 1;
			dataGridView3.TabStop = false;
			// 
			// Icon3
			// 
			Icon3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Icon3.FillWeight = 50F;
			Icon3.HeaderText = "圖示";
			Icon3.ImageLayout = DataGridViewImageCellLayout.Zoom;
			Icon3.Name = "Icon3";
			Icon3.Resizable = DataGridViewTriState.True;
			Icon3.SortMode = DataGridViewColumnSortMode.Automatic;
			Icon3.ToolTipText = "圖示";
			Icon3.Width = 50;
			// 
			// ProcessName3
			// 
			ProcessName3.HeaderText = "進程檔名";
			ProcessName3.Name = "ProcessName3";
			ProcessName3.ToolTipText = "進程檔名";
			// 
			// ProcessId3
			// 
			ProcessId3.HeaderText = "進程pid";
			ProcessId3.Name = "ProcessId3";
			ProcessId3.ToolTipText = "進程pid";
			// 
			// LocalAddress3
			// 
			LocalAddress3.FillWeight = 200F;
			LocalAddress3.HeaderText = "本機位址";
			LocalAddress3.Name = "LocalAddress3";
			LocalAddress3.ToolTipText = "本機位址";
			LocalAddress3.Width = 200;
			// 
			// LocalPort3
			// 
			LocalPort3.HeaderText = "本機埠";
			LocalPort3.Name = "LocalPort3";
			LocalPort3.ToolTipText = "本機埠";
			// 
			// RemoteAddress3
			// 
			RemoteAddress3.FillWeight = 200F;
			RemoteAddress3.HeaderText = "遠端位址";
			RemoteAddress3.Name = "RemoteAddress3";
			RemoteAddress3.ToolTipText = "遠端位址";
			RemoteAddress3.Width = 200;
			// 
			// RemotePort3
			// 
			RemotePort3.HeaderText = "遠端埠";
			RemotePort3.Name = "RemotePort3";
			RemotePort3.ToolTipText = "遠端埠";
			// 
			// State3
			// 
			State3.HeaderText = "狀態";
			State3.Name = "State3";
			State3.ToolTipText = "狀態";
			// 
			// ApplicationPath3
			// 
			ApplicationPath3.FillWeight = 300F;
			ApplicationPath3.HeaderText = "應用程式路徑";
			ApplicationPath3.Name = "ApplicationPath3";
			ApplicationPath3.ToolTipText = "應用程式路徑";
			ApplicationPath3.Width = 300;
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(dataGridView4);
			tabPage4.Location = new Point(4,24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(1176,571);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "UDPV6";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// dataGridView4
			// 
			dataGridView4.AllowUserToAddRows = false;
			dataGridView4.AllowUserToResizeColumns = false;
			dataGridView4.AllowUserToResizeRows = false;
			dataGridView4.BackgroundColor = Color.White;
			dataGridView4.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = SystemColors.Control;
			dataGridViewCellStyle10.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Icon4,ProcessName4,ProcessId4,LocalAddress4,LocalPort4,RemoteAddress4,RemotePort4,State4,ApplicationPath4 });
			dataGridView4.ContextMenuStrip = contextMenuStrip1;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = SystemColors.Window;
			dataGridViewCellStyle11.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
			dataGridView4.DefaultCellStyle = dataGridViewCellStyle11;
			dataGridView4.Dock = DockStyle.Fill;
			dataGridView4.Location = new Point(3,3);
			dataGridView4.MultiSelect = false;
			dataGridView4.Name = "dataGridView4";
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = SystemColors.Control;
			dataGridViewCellStyle12.Font = new Font("Microsoft JhengHei UI",9.75F,FontStyle.Regular,GraphicsUnit.Point,136);
			dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
			dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			dataGridView4.RowHeadersVisible = false;
			dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView4.Size = new Size(1170,565);
			dataGridView4.TabIndex = 1;
			dataGridView4.TabStop = false;
			// 
			// Icon4
			// 
			Icon4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			Icon4.FillWeight = 50F;
			Icon4.HeaderText = "圖示";
			Icon4.ImageLayout = DataGridViewImageCellLayout.Zoom;
			Icon4.Name = "Icon4";
			Icon4.Resizable = DataGridViewTriState.True;
			Icon4.SortMode = DataGridViewColumnSortMode.Automatic;
			Icon4.ToolTipText = "圖示";
			Icon4.Width = 50;
			// 
			// ProcessName4
			// 
			ProcessName4.HeaderText = "進程檔名";
			ProcessName4.Name = "ProcessName4";
			ProcessName4.ToolTipText = "進程檔名";
			// 
			// ProcessId4
			// 
			ProcessId4.HeaderText = "進程pid";
			ProcessId4.Name = "ProcessId4";
			ProcessId4.ToolTipText = "進程pid";
			// 
			// LocalAddress4
			// 
			LocalAddress4.FillWeight = 200F;
			LocalAddress4.HeaderText = "本機位址";
			LocalAddress4.Name = "LocalAddress4";
			LocalAddress4.ToolTipText = "本機位址";
			LocalAddress4.Width = 200;
			// 
			// LocalPort4
			// 
			LocalPort4.HeaderText = "本機埠";
			LocalPort4.Name = "LocalPort4";
			LocalPort4.ToolTipText = "本機埠";
			// 
			// RemoteAddress4
			// 
			RemoteAddress4.FillWeight = 200F;
			RemoteAddress4.HeaderText = "遠端位址";
			RemoteAddress4.Name = "RemoteAddress4";
			RemoteAddress4.ToolTipText = "遠端位址";
			RemoteAddress4.Width = 200;
			// 
			// RemotePort4
			// 
			RemotePort4.HeaderText = "遠端埠";
			RemotePort4.Name = "RemotePort4";
			RemotePort4.ToolTipText = "遠端埠";
			// 
			// State4
			// 
			State4.HeaderText = "狀態";
			State4.Name = "State4";
			State4.ToolTipText = "狀態";
			// 
			// ApplicationPath4
			// 
			ApplicationPath4.FillWeight = 300F;
			ApplicationPath4.HeaderText = "應用程式路徑";
			ApplicationPath4.Name = "ApplicationPath4";
			ApplicationPath4.ToolTipText = "應用程式路徑";
			ApplicationPath4.Width = 300;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1,toolStripStatusLabel2,toolStripStatusLabel3,toolStripStatusLabel4,toolStripStatusLabel5,toolStripStatusLabel6 });
			statusStrip1.Location = new Point(0,639);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1184,22);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(74,17);
			toolStripStatusLabel1.Text = "全部端點：0";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(62,17);
			toolStripStatusLabel2.Text = "已建立：0";
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(62,17);
			toolStripStatusLabel3.Text = "監聽中：0";
			// 
			// toolStripStatusLabel4
			// 
			toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			toolStripStatusLabel4.Size = new Size(74,17);
			toolStripStatusLabel4.Text = "等待時間：0";
			// 
			// toolStripStatusLabel5
			// 
			toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			toolStripStatusLabel5.Size = new Size(74,17);
			toolStripStatusLabel5.Text = "關閉等待：0";
			// 
			// toolStripStatusLabel6
			// 
			toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			toolStripStatusLabel6.Size = new Size(62,17);
			toolStripStatusLabel6.Text = "已結束：0";
			// 
			// panel1
			// 
			panel1.Controls.Add(searchBox);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0,0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1184,40);
			panel1.TabIndex = 3;
			// 
			// searchBox
			// 
			searchBox.Location = new Point(57,8);
			searchBox.Name = "searchBox";
			searchBox.PlaceholderText = "請輸入進程檔名關鍵字搜尋...";
			searchBox.Size = new Size(450,23);
			searchBox.TabIndex = 1;
			searchBox.TabStop = false;
			searchBox.KeyUp += textBox1_KeyUp;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12,13);
			label1.Name = "label1";
			label1.Size = new Size(31,15);
			label1.TabIndex = 0;
			label1.Text = "搜尋";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F,15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(1184,661);
			Controls.Add(tabControl1);
			Controls.Add(panel1);
			Controls.Add(statusStrip1);
			DoubleBuffered = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TCPView";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			contextMenuStrip1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public DataGridView dataGridView1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel3;
		private ToolStripStatusLabel toolStripStatusLabel4;
		private ToolStripStatusLabel toolStripStatusLabel5;
		private ToolStripStatusLabel toolStripStatusLabel6;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem toolStripMenuItem2;
		public DataGridView dataGridView2;
		public DataGridView dataGridView3;
		private TabPage tabPage4;
		public DataGridView dataGridView4;
		private Panel panel1;
		private Label label1;
		private TextBox searchBox;
		private DataGridViewImageColumn Icon1;
		private DataGridViewTextBoxColumn ProcessName1;
		private DataGridViewTextBoxColumn ProcessId1;
		private DataGridViewTextBoxColumn LocalAddress1;
		private DataGridViewTextBoxColumn LocalPort1;
		private DataGridViewTextBoxColumn RemoteAddress1;
		private DataGridViewTextBoxColumn RemotePort1;
		private DataGridViewTextBoxColumn State1;
		private DataGridViewTextBoxColumn ApplicationPath1;
		private DataGridViewImageColumn Icon2;
		private DataGridViewTextBoxColumn ProcessName2;
		private DataGridViewTextBoxColumn ProcessId2;
		private DataGridViewTextBoxColumn LocalAddress2;
		private DataGridViewTextBoxColumn LocalPort2;
		private DataGridViewTextBoxColumn RemoteAddress2;
		private DataGridViewTextBoxColumn RemotePort2;
		private DataGridViewTextBoxColumn State2;
		private DataGridViewTextBoxColumn ApplicationPath2;
		private DataGridViewImageColumn Icon3;
		private DataGridViewTextBoxColumn ProcessName3;
		private DataGridViewTextBoxColumn ProcessId3;
		private DataGridViewTextBoxColumn LocalAddress3;
		private DataGridViewTextBoxColumn LocalPort3;
		private DataGridViewTextBoxColumn RemoteAddress3;
		private DataGridViewTextBoxColumn RemotePort3;
		private DataGridViewTextBoxColumn State3;
		private DataGridViewTextBoxColumn ApplicationPath3;
		private DataGridViewImageColumn Icon4;
		private DataGridViewTextBoxColumn ProcessName4;
		private DataGridViewTextBoxColumn ProcessId4;
		private DataGridViewTextBoxColumn LocalAddress4;
		private DataGridViewTextBoxColumn LocalPort4;
		private DataGridViewTextBoxColumn RemoteAddress4;
		private DataGridViewTextBoxColumn RemotePort4;
		private DataGridViewTextBoxColumn State4;
		private DataGridViewTextBoxColumn ApplicationPath4;
	}
}
