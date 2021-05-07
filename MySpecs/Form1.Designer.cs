namespace MySpecs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_device_info = new System.Windows.Forms.TabPage();
            this.lbl_owner_company = new System.Windows.Forms.Label();
            this.lbl_owner_name = new System.Windows.Forms.Label();
            this.lbl_process_arch = new System.Windows.Forms.Label();
            this.lbl_framework = new System.Windows.Forms.Label();
            this.lbl_os_arch = new System.Windows.Forms.Label();
            this.lbl_os_desc = new System.Windows.Forms.Label();
            this.tab_usb = new System.Windows.Forms.TabPage();
            this.lvwDevices = new System.Windows.Forms.ListView();
            this.colDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPnPDeviceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_fonts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstbx_fonts = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_fonts = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chk_underline = new System.Windows.Forms.CheckBox();
            this.chkbx_bold = new System.Windows.Forms.CheckBox();
            this.chkbx_strikethough = new System.Windows.Forms.CheckBox();
            this.chkbx_italic = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbx_size = new System.Windows.Forms.TextBox();
            this.lbl_font_size = new System.Windows.Forms.Label();
            this.tab_mem = new System.Windows.Forms.TabPage();
            this.lvwInfo = new System.Windows.Forms.ListView();
            this.tab_disk_info = new System.Windows.Forms.TabPage();
            this.rchtxtbx_disk_info2 = new System.Windows.Forms.RichTextBox();
            this.tab_HardwareInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbobx_info_type = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbobx_info_category = new System.Windows.Forms.ComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lstview_data = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_device_info.SuspendLayout();
            this.tab_usb.SuspendLayout();
            this.tab_fonts.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tab_mem.SuspendLayout();
            this.tab_disk_info.SuspendLayout();
            this.tab_HardwareInfo.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 495);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_device_info);
            this.tabControl1.Controls.Add(this.tab_usb);
            this.tabControl1.Controls.Add(this.tab_fonts);
            this.tabControl1.Controls.Add(this.tab_mem);
            this.tabControl1.Controls.Add(this.tab_disk_info);
            this.tabControl1.Controls.Add(this.tab_HardwareInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_device_info
            // 
            this.tab_device_info.Controls.Add(this.lbl_owner_company);
            this.tab_device_info.Controls.Add(this.lbl_owner_name);
            this.tab_device_info.Controls.Add(this.lbl_process_arch);
            this.tab_device_info.Controls.Add(this.lbl_framework);
            this.tab_device_info.Controls.Add(this.lbl_os_arch);
            this.tab_device_info.Controls.Add(this.lbl_os_desc);
            this.tab_device_info.Location = new System.Drawing.Point(4, 25);
            this.tab_device_info.Name = "tab_device_info";
            this.tab_device_info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_device_info.Size = new System.Drawing.Size(921, 466);
            this.tab_device_info.TabIndex = 3;
            this.tab_device_info.Text = "Device Info";
            this.tab_device_info.UseVisualStyleBackColor = true;
            // 
            // lbl_owner_company
            // 
            this.lbl_owner_company.AutoSize = true;
            this.lbl_owner_company.Location = new System.Drawing.Point(42, 32);
            this.lbl_owner_company.Name = "lbl_owner_company";
            this.lbl_owner_company.Size = new System.Drawing.Size(83, 17);
            this.lbl_owner_company.TabIndex = 5;
            this.lbl_owner_company.Text = "..Company..";
            // 
            // lbl_owner_name
            // 
            this.lbl_owner_name.AutoSize = true;
            this.lbl_owner_name.Location = new System.Drawing.Point(42, 15);
            this.lbl_owner_name.Name = "lbl_owner_name";
            this.lbl_owner_name.Size = new System.Drawing.Size(65, 17);
            this.lbl_owner_name.TabIndex = 4;
            this.lbl_owner_name.Text = "..Owner..";
            // 
            // lbl_process_arch
            // 
            this.lbl_process_arch.AutoSize = true;
            this.lbl_process_arch.Location = new System.Drawing.Point(42, 90);
            this.lbl_process_arch.Name = "lbl_process_arch";
            this.lbl_process_arch.Size = new System.Drawing.Size(108, 17);
            this.lbl_process_arch.TabIndex = 3;
            this.lbl_process_arch.Text = "..Process Arch..";
            // 
            // lbl_framework
            // 
            this.lbl_framework.AutoSize = true;
            this.lbl_framework.Location = new System.Drawing.Point(42, 170);
            this.lbl_framework.Name = "lbl_framework";
            this.lbl_framework.Size = new System.Drawing.Size(93, 17);
            this.lbl_framework.TabIndex = 2;
            this.lbl_framework.Text = "..Framework..";
            // 
            // lbl_os_arch
            // 
            this.lbl_os_arch.AutoSize = true;
            this.lbl_os_arch.Location = new System.Drawing.Point(40, 123);
            this.lbl_os_arch.Name = "lbl_os_arch";
            this.lbl_os_arch.Size = new System.Drawing.Size(76, 17);
            this.lbl_os_arch.TabIndex = 1;
            this.lbl_os_arch.Text = "..OS arch..";
            // 
            // lbl_os_desc
            // 
            this.lbl_os_desc.AutoSize = true;
            this.lbl_os_desc.Location = new System.Drawing.Point(40, 140);
            this.lbl_os_desc.Name = "lbl_os_desc";
            this.lbl_os_desc.Size = new System.Drawing.Size(78, 17);
            this.lbl_os_desc.TabIndex = 0;
            this.lbl_os_desc.Text = "..OS desc..";
            // 
            // tab_usb
            // 
            this.tab_usb.Controls.Add(this.lvwDevices);
            this.tab_usb.Location = new System.Drawing.Point(4, 25);
            this.tab_usb.Name = "tab_usb";
            this.tab_usb.Padding = new System.Windows.Forms.Padding(3);
            this.tab_usb.Size = new System.Drawing.Size(921, 466);
            this.tab_usb.TabIndex = 0;
            this.tab_usb.Text = "USB Devices";
            this.tab_usb.UseVisualStyleBackColor = true;
            // 
            // lvwDevices
            // 
            this.lvwDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDevice,
            this.colPnPDeviceId,
            this.colDescription});
            this.lvwDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDevices.HideSelection = false;
            this.lvwDevices.Location = new System.Drawing.Point(3, 3);
            this.lvwDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lvwDevices.Name = "lvwDevices";
            this.lvwDevices.Size = new System.Drawing.Size(915, 460);
            this.lvwDevices.TabIndex = 2;
            this.lvwDevices.UseCompatibleStateImageBehavior = false;
            this.lvwDevices.View = System.Windows.Forms.View.Details;
            // 
            // colDevice
            // 
            this.colDevice.Text = "Device";
            this.colDevice.Width = 283;
            // 
            // colPnPDeviceId
            // 
            this.colPnPDeviceId.Text = "PnP Device ID";
            this.colPnPDeviceId.Width = 305;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 313;
            // 
            // tab_fonts
            // 
            this.tab_fonts.Controls.Add(this.tableLayoutPanel2);
            this.tab_fonts.Location = new System.Drawing.Point(4, 25);
            this.tab_fonts.Name = "tab_fonts";
            this.tab_fonts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_fonts.Size = new System.Drawing.Size(921, 466);
            this.tab_fonts.TabIndex = 1;
            this.tab_fonts.Text = "Fonts";
            this.tab_fonts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.625F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 460);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstbx_fonts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 359);
            this.panel3.TabIndex = 0;
            // 
            // lstbx_fonts
            // 
            this.lstbx_fonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbx_fonts.FormattingEnabled = true;
            this.lstbx_fonts.ItemHeight = 16;
            this.lstbx_fonts.Location = new System.Drawing.Point(0, 0);
            this.lstbx_fonts.Name = "lstbx_fonts";
            this.lstbx_fonts.Size = new System.Drawing.Size(909, 359);
            this.lstbx_fonts.TabIndex = 0;
            this.lstbx_fonts.SelectedIndexChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 89);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(909, 89);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_fonts);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 83);
            this.panel5.TabIndex = 0;
            // 
            // lbl_fonts
            // 
            this.lbl_fonts.AutoSize = true;
            this.lbl_fonts.Location = new System.Drawing.Point(13, 35);
            this.lbl_fonts.Name = "lbl_fonts";
            this.lbl_fonts.Size = new System.Drawing.Size(32, 17);
            this.lbl_fonts.TabIndex = 0;
            this.lbl_fonts.Text = "......";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chk_underline);
            this.panel6.Controls.Add(this.chkbx_bold);
            this.panel6.Controls.Add(this.chkbx_strikethough);
            this.panel6.Controls.Add(this.chkbx_italic);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(401, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 83);
            this.panel6.TabIndex = 1;
            // 
            // chk_underline
            // 
            this.chk_underline.AutoSize = true;
            this.chk_underline.Location = new System.Drawing.Point(157, 17);
            this.chk_underline.Name = "chk_underline";
            this.chk_underline.Size = new System.Drawing.Size(91, 21);
            this.chk_underline.TabIndex = 4;
            this.chk_underline.Text = "Underline";
            this.chk_underline.UseVisualStyleBackColor = true;
            this.chk_underline.CheckedChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // chkbx_bold
            // 
            this.chkbx_bold.AutoSize = true;
            this.chkbx_bold.Location = new System.Drawing.Point(53, 17);
            this.chkbx_bold.Name = "chkbx_bold";
            this.chkbx_bold.Size = new System.Drawing.Size(58, 21);
            this.chkbx_bold.TabIndex = 2;
            this.chkbx_bold.Text = "Bold";
            this.chkbx_bold.UseVisualStyleBackColor = true;
            this.chkbx_bold.CheckedChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // chkbx_strikethough
            // 
            this.chkbx_strikethough.AutoSize = true;
            this.chkbx_strikethough.Location = new System.Drawing.Point(157, 46);
            this.chkbx_strikethough.Name = "chkbx_strikethough";
            this.chkbx_strikethough.Size = new System.Drawing.Size(115, 21);
            this.chkbx_strikethough.TabIndex = 3;
            this.chkbx_strikethough.Text = "Strikethrough";
            this.chkbx_strikethough.UseVisualStyleBackColor = true;
            this.chkbx_strikethough.CheckedChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // chkbx_italic
            // 
            this.chkbx_italic.AutoSize = true;
            this.chkbx_italic.Location = new System.Drawing.Point(53, 46);
            this.chkbx_italic.Name = "chkbx_italic";
            this.chkbx_italic.Size = new System.Drawing.Size(58, 21);
            this.chkbx_italic.TabIndex = 1;
            this.chkbx_italic.Text = "Italic";
            this.chkbx_italic.UseVisualStyleBackColor = true;
            this.chkbx_italic.CheckedChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtbx_size);
            this.panel7.Controls.Add(this.lbl_font_size);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(799, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(107, 83);
            this.panel7.TabIndex = 2;
            // 
            // txtbx_size
            // 
            this.txtbx_size.Location = new System.Drawing.Point(27, 46);
            this.txtbx_size.Name = "txtbx_size";
            this.txtbx_size.Size = new System.Drawing.Size(59, 22);
            this.txtbx_size.TabIndex = 1;
            this.txtbx_size.Text = "20";
            this.txtbx_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbx_size.TextChanged += new System.EventHandler(this.lstbx_fonts_SelectedIndexChanged);
            // 
            // lbl_font_size
            // 
            this.lbl_font_size.AutoSize = true;
            this.lbl_font_size.Location = new System.Drawing.Point(20, 17);
            this.lbl_font_size.Name = "lbl_font_size";
            this.lbl_font_size.Size = new System.Drawing.Size(67, 17);
            this.lbl_font_size.TabIndex = 0;
            this.lbl_font_size.Text = "Font Size";
            // 
            // tab_mem
            // 
            this.tab_mem.Controls.Add(this.lvwInfo);
            this.tab_mem.Location = new System.Drawing.Point(4, 25);
            this.tab_mem.Name = "tab_mem";
            this.tab_mem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mem.Size = new System.Drawing.Size(921, 466);
            this.tab_mem.TabIndex = 2;
            this.tab_mem.Text = "Memory Info";
            this.tab_mem.UseVisualStyleBackColor = true;
            // 
            // lvwInfo
            // 
            this.lvwInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwInfo.HideSelection = false;
            this.lvwInfo.Location = new System.Drawing.Point(3, 3);
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.Size = new System.Drawing.Size(915, 460);
            this.lvwInfo.TabIndex = 0;
            this.lvwInfo.UseCompatibleStateImageBehavior = false;
            // 
            // tab_disk_info
            // 
            this.tab_disk_info.Controls.Add(this.rchtxtbx_disk_info2);
            this.tab_disk_info.Location = new System.Drawing.Point(4, 25);
            this.tab_disk_info.Name = "tab_disk_info";
            this.tab_disk_info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_disk_info.Size = new System.Drawing.Size(921, 466);
            this.tab_disk_info.TabIndex = 4;
            this.tab_disk_info.Text = "Disk Info";
            this.tab_disk_info.UseVisualStyleBackColor = true;
            // 
            // rchtxtbx_disk_info2
            // 
            this.rchtxtbx_disk_info2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_disk_info2.Location = new System.Drawing.Point(3, 3);
            this.rchtxtbx_disk_info2.Name = "rchtxtbx_disk_info2";
            this.rchtxtbx_disk_info2.Size = new System.Drawing.Size(915, 460);
            this.rchtxtbx_disk_info2.TabIndex = 0;
            this.rchtxtbx_disk_info2.Text = "";
            // 
            // tab_HardwareInfo
            // 
            this.tab_HardwareInfo.Controls.Add(this.tableLayoutPanel5);
            this.tab_HardwareInfo.Location = new System.Drawing.Point(4, 25);
            this.tab_HardwareInfo.Name = "tab_HardwareInfo";
            this.tab_HardwareInfo.Size = new System.Drawing.Size(921, 466);
            this.tab_HardwareInfo.TabIndex = 6;
            this.tab_HardwareInfo.Text = "Hardware Info";
            this.tab_HardwareInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel12, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.583691F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.41631F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(921, 466);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cmbobx_info_type);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(454, 33);
            this.panel10.TabIndex = 0;
            // 
            // cmbobx_info_type
            // 
            this.cmbobx_info_type.FormattingEnabled = true;
            this.cmbobx_info_type.Items.AddRange(new object[] {
            "Hardware Info",
            "Data Storage",
            "Memory",
            "System Info",
            "Network",
            "Account Info",
            "Developer",
            "Utility"});
            this.cmbobx_info_type.Location = new System.Drawing.Point(146, 3);
            this.cmbobx_info_type.Name = "cmbobx_info_type";
            this.cmbobx_info_type.Size = new System.Drawing.Size(162, 24);
            this.cmbobx_info_type.TabIndex = 3;
            this.cmbobx_info_type.SelectedIndexChanged += new System.EventHandler(this.cmbobx_info_type_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cmbobx_info_category);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(463, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(455, 33);
            this.panel11.TabIndex = 1;
            // 
            // cmbobx_info_category
            // 
            this.cmbobx_info_category.FormattingEnabled = true;
            this.cmbobx_info_category.Location = new System.Drawing.Point(92, 3);
            this.cmbobx_info_category.Name = "cmbobx_info_category";
            this.cmbobx_info_category.Size = new System.Drawing.Size(271, 24);
            this.cmbobx_info_category.TabIndex = 4;
            this.cmbobx_info_category.SelectedIndexChanged += new System.EventHandler(this.cmbobx_info_category_SelectedIndexChanged);
            // 
            // panel12
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.panel12, 2);
            this.panel12.Controls.Add(this.lstview_data);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 42);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(915, 421);
            this.panel12.TabIndex = 2;
            // 
            // lstview_data
            // 
            this.lstview_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstview_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstview_data.HideSelection = false;
            this.lstview_data.Location = new System.Drawing.Point(0, 0);
            this.lstview_data.Margin = new System.Windows.Forms.Padding(4);
            this.lstview_data.Name = "lstview_data";
            this.lstview_data.Size = new System.Drawing.Size(915, 421);
            this.lstview_data.TabIndex = 1;
            this.lstview_data.UseCompatibleStateImageBehavior = false;
            this.lstview_data.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 647;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_version);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 56);
            this.panel2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(767, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(141, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(20, 20);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(20, 17);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MySpecs - This PCs Specifications";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_device_info.ResumeLayout(false);
            this.tab_device_info.PerformLayout();
            this.tab_usb.ResumeLayout(false);
            this.tab_fonts.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tab_mem.ResumeLayout(false);
            this.tab_disk_info.ResumeLayout(false);
            this.tab_HardwareInfo.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_usb;
        private System.Windows.Forms.TabPage tab_fonts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox lstbx_fonts;
        public System.Windows.Forms.Label lbl_fonts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_font_size;
        public System.Windows.Forms.TextBox txtbx_size;
        public System.Windows.Forms.CheckBox chk_underline;
        public System.Windows.Forms.CheckBox chkbx_bold;
        public System.Windows.Forms.CheckBox chkbx_strikethough;
        public System.Windows.Forms.CheckBox chkbx_italic;
        private System.Windows.Forms.TabPage tab_mem;
        public System.Windows.Forms.ListView lvwInfo;
        private System.Windows.Forms.TabPage tab_device_info;
        private System.Windows.Forms.ColumnHeader colDevice;
        private System.Windows.Forms.ColumnHeader colPnPDeviceId;
        private System.Windows.Forms.ColumnHeader colDescription;
        public System.Windows.Forms.ListView lvwDevices;
        public System.Windows.Forms.Label lbl_os_desc;
        public System.Windows.Forms.Label lbl_process_arch;
        public System.Windows.Forms.Label lbl_framework;
        public System.Windows.Forms.Label lbl_os_arch;
        public System.Windows.Forms.Label lbl_owner_company;
        public System.Windows.Forms.Label lbl_owner_name;
        private System.Windows.Forms.TabPage tab_disk_info;
        public System.Windows.Forms.RichTextBox rchtxtbx_disk_info2;
        private System.Windows.Forms.TabPage tab_HardwareInfo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cmbobx_info_type;
        public System.Windows.Forms.ListView lstview_data;
        private System.Windows.Forms.ComboBox cmbobx_info_category;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_version;
    }
}

