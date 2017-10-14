namespace barcode_printer
{
    partial class mainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout gridEX2_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.main_toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolstrp_printtemple = new System.Windows.Forms.ToolStripButton();
            this.toolstrip_codeprint = new System.Windows.Forms.ToolStripButton();
            this.manual_print = new System.Windows.Forms.ToolStripButton();
            this.toolstrip_codecheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.page_up = new System.Windows.Forms.ToolStripButton();
            this.page_down = new System.Windows.Forms.ToolStripButton();
            this.tbJumpoffset = new System.Windows.Forms.ToolStripTextBox();
            this.jump_pageoffset = new System.Windows.Forms.ToolStripButton();
            this.print_minmax = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialport_iotrans = new System.IO.Ports.SerialPort(this.components);
            this.lblog = new System.Windows.Forms.Label();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbWarningMsg = new System.Windows.Forms.Label();
            this.btnCancelScan = new System.Windows.Forms.Button();
            this.gridEX2 = new Janus.Windows.GridEX.GridEX();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lbPrivate = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIN4 = new System.Windows.Forms.Label();
            this.lbIN3 = new System.Windows.Forms.Label();
            this.lbIN2 = new System.Windows.Forms.Label();
            this.lbIN1 = new System.Windows.Forms.Label();
            this.lbIN0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOUT4 = new System.Windows.Forms.Label();
            this.lbOUT3 = new System.Windows.Forms.Label();
            this.lbOUT2 = new System.Windows.Forms.Label();
            this.lbOUT1 = new System.Windows.Forms.Label();
            this.lbOUT0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialport_printer = new System.IO.Ports.SerialPort(this.components);
            this.timer_cheksn = new System.Windows.Forms.Timer(this.components);
            this.timer_check_ready = new System.Windows.Forms.Timer(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.echo_msg1 = new barcode_printer.echo_msg();
            this.main_toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX2)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_toolstrip
            // 
            this.main_toolstrip.BackColor = System.Drawing.SystemColors.Control;
            this.main_toolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.main_toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrp_printtemple,
            this.toolstrip_codeprint,
            this.manual_print,
            this.toolstrip_codecheck,
            this.toolStripSeparator1,
            this.page_up,
            this.page_down,
            this.tbJumpoffset,
            this.jump_pageoffset,
            this.print_minmax});
            this.main_toolstrip.Location = new System.Drawing.Point(0, 0);
            this.main_toolstrip.Name = "main_toolstrip";
            this.main_toolstrip.Size = new System.Drawing.Size(884, 25);
            this.main_toolstrip.TabIndex = 1;
            this.main_toolstrip.Text = "maintoolstrip";
            // 
            // toolstrp_printtemple
            // 
            this.toolstrp_printtemple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrp_printtemple.Image = ((System.Drawing.Image)(resources.GetObject("toolstrp_printtemple.Image")));
            this.toolstrp_printtemple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrp_printtemple.Name = "toolstrp_printtemple";
            this.toolstrp_printtemple.Size = new System.Drawing.Size(60, 22);
            this.toolstrp_printtemple.Text = "标签文件";
            this.toolstrp_printtemple.Click += new System.EventHandler(this.toolstrp_printtemple_Click);
            // 
            // toolstrip_codeprint
            // 
            this.toolstrip_codeprint.BackColor = System.Drawing.Color.Transparent;
            this.toolstrip_codeprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrip_codeprint.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_codeprint.Image")));
            this.toolstrip_codeprint.ImageTransparentColor = System.Drawing.Color.White;
            this.toolstrip_codeprint.Name = "toolstrip_codeprint";
            this.toolstrip_codeprint.Size = new System.Drawing.Size(60, 22);
            this.toolstrip_codeprint.Text = "通讯设置";
            this.toolstrip_codeprint.Click += new System.EventHandler(this.toolstrip_codeprint_Click);
            // 
            // manual_print
            // 
            this.manual_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.manual_print.Image = ((System.Drawing.Image)(resources.GetObject("manual_print.Image")));
            this.manual_print.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.manual_print.Name = "manual_print";
            this.manual_print.Size = new System.Drawing.Size(60, 22);
            this.manual_print.Text = "单次打印";
            this.manual_print.Click += new System.EventHandler(this.manual_print_Click);
            // 
            // toolstrip_codecheck
            // 
            this.toolstrip_codecheck.BackColor = System.Drawing.Color.Transparent;
            this.toolstrip_codecheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrip_codecheck.Enabled = false;
            this.toolstrip_codecheck.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_codecheck.Image")));
            this.toolstrip_codecheck.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolstrip_codecheck.Name = "toolstrip_codecheck";
            this.toolstrip_codecheck.Size = new System.Drawing.Size(96, 22);
            this.toolstrip_codecheck.Text = "打开标签扫描仪";
            this.toolstrip_codecheck.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // page_up
            // 
            this.page_up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.page_up.Image = ((System.Drawing.Image)(resources.GetObject("page_up.Image")));
            this.page_up.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.page_up.Name = "page_up";
            this.page_up.Size = new System.Drawing.Size(36, 22);
            this.page_up.Text = "前页";
            this.page_up.Click += new System.EventHandler(this.page_up_Click);
            // 
            // page_down
            // 
            this.page_down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.page_down.Image = ((System.Drawing.Image)(resources.GetObject("page_down.Image")));
            this.page_down.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.page_down.Name = "page_down";
            this.page_down.Size = new System.Drawing.Size(36, 22);
            this.page_down.Text = "后页";
            this.page_down.Click += new System.EventHandler(this.page_down_Click);
            // 
            // tbJumpoffset
            // 
            this.tbJumpoffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJumpoffset.Name = "tbJumpoffset";
            this.tbJumpoffset.Size = new System.Drawing.Size(100, 25);
            this.tbJumpoffset.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJumpoffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumpoffset_KeyPress);
            // 
            // jump_pageoffset
            // 
            this.jump_pageoffset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.jump_pageoffset.Image = ((System.Drawing.Image)(resources.GetObject("jump_pageoffset.Image")));
            this.jump_pageoffset.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.jump_pageoffset.Name = "jump_pageoffset";
            this.jump_pageoffset.Size = new System.Drawing.Size(36, 22);
            this.jump_pageoffset.Text = "查找";
            this.jump_pageoffset.Click += new System.EventHandler(this.jump_pageoffset_Click);
            // 
            // print_minmax
            // 
            this.print_minmax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.print_minmax.Image = ((System.Drawing.Image)(resources.GetObject("print_minmax.Image")));
            this.print_minmax.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.print_minmax.Name = "print_minmax";
            this.print_minmax.Size = new System.Drawing.Size(60, 22);
            this.print_minmax.Text = "参数设置";
            this.print_minmax.Click += new System.EventHandler(this.print_minmax_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "数据库文件|*.db3|所有文件|*.*";
            this.openFileDialog1.Title = "选择待打印数据文件";
            // 
            // serialport_iotrans
            // 
            this.serialport_iotrans.BaudRate = 115200;
            this.serialport_iotrans.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialport_iotrans_DataReceived);
            // 
            // lblog
            // 
            this.lblog.AutoSize = true;
            this.lblog.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblog.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblog.Location = new System.Drawing.Point(4, 85);
            this.lblog.Name = "lblog";
            this.lblog.Size = new System.Drawing.Size(69, 19);
            this.lblog.TabIndex = 18;
            this.lblog.Text = "打印列表:";
            this.lblog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridEX1
            // 
            this.gridEX1.AllowColumnDrag = false;
            this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.gridEX1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.Location = new System.Drawing.Point(2, 107);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.RowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.Size = new System.Drawing.Size(881, 233);
            this.gridEX1.TabIndex = 30;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005;
            this.gridEX1.SizingColumn += new Janus.Windows.GridEX.SizingColumnEventHandler(this.gridEX1_SizingColumn);
            this.gridEX1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEX1_FormattingRow);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "操作历史记录:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbWarningMsg);
            this.panel3.Controls.Add(this.btnCancelScan);
            this.panel3.Location = new System.Drawing.Point(3, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 53);
            this.panel3.TabIndex = 32;
            // 
            // lbWarningMsg
            // 
            this.lbWarningMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWarningMsg.AutoEllipsis = true;
            this.lbWarningMsg.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWarningMsg.ForeColor = System.Drawing.Color.Red;
            this.lbWarningMsg.Location = new System.Drawing.Point(3, 3);
            this.lbWarningMsg.Name = "lbWarningMsg";
            this.lbWarningMsg.Size = new System.Drawing.Size(776, 47);
            this.lbWarningMsg.TabIndex = 32;
            this.lbWarningMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelScan
            // 
            this.btnCancelScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelScan.Location = new System.Drawing.Point(798, 2);
            this.btnCancelScan.Name = "btnCancelScan";
            this.btnCancelScan.Size = new System.Drawing.Size(75, 47);
            this.btnCancelScan.TabIndex = 31;
            this.btnCancelScan.Text = "取消扫描";
            this.btnCancelScan.UseVisualStyleBackColor = true;
            this.btnCancelScan.Visible = false;
            this.btnCancelScan.Click += new System.EventHandler(this.btnCancelScan_Click);
            // 
            // gridEX2
            // 
            this.gridEX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            gridEX2_DesignTimeLayout.LayoutString = resources.GetString("gridEX2_DesignTimeLayout.LayoutString");
            this.gridEX2.DesignTimeLayout = gridEX2_DesignTimeLayout;
            this.gridEX2.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.gridEX2.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEX2.GroupByBoxVisible = false;
            this.gridEX2.Location = new System.Drawing.Point(2, 367);
            this.gridEX2.Name = "gridEX2";
            this.gridEX2.Size = new System.Drawing.Size(881, 128);
            this.gridEX2.TabIndex = 33;
            this.gridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005;
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackColor = System.Drawing.Color.White;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.lbPrivate);
            this.panelStatus.Controls.Add(this.lbLink);
            this.panelStatus.Controls.Add(this.panel2);
            this.panelStatus.Controls.Add(this.panel1);
            this.panelStatus.Location = new System.Drawing.Point(1, 527);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(883, 32);
            this.panelStatus.TabIndex = 34;
            // 
            // lbPrivate
            // 
            this.lbPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrivate.AutoSize = true;
            this.lbPrivate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPrivate.Location = new System.Drawing.Point(778, 8);
            this.lbPrivate.Name = "lbPrivate";
            this.lbPrivate.Size = new System.Drawing.Size(44, 12);
            this.lbPrivate.TabIndex = 31;
            this.lbPrivate.Text = "操作员";
            this.lbPrivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLink
            // 
            this.lbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLink.AutoSize = true;
            this.lbLink.BackColor = System.Drawing.Color.Gray;
            this.lbLink.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLink.ForeColor = System.Drawing.Color.White;
            this.lbLink.Location = new System.Drawing.Point(10, 6);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(53, 19);
            this.lbLink.TabIndex = 30;
            this.lbLink.Text = "LINK";
            this.lbLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lbIN4);
            this.panel2.Controls.Add(this.lbIN3);
            this.panel2.Controls.Add(this.lbIN2);
            this.panel2.Controls.Add(this.lbIN1);
            this.panel2.Controls.Add(this.lbIN0);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(155, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 27);
            this.panel2.TabIndex = 29;
            // 
            // lbIN4
            // 
            this.lbIN4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIN4.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbIN4.Location = new System.Drawing.Point(171, 1);
            this.lbIN4.Name = "lbIN4";
            this.lbIN4.Size = new System.Drawing.Size(42, 24);
            this.lbIN4.TabIndex = 12;
            // 
            // lbIN3
            // 
            this.lbIN3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIN3.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbIN3.Location = new System.Drawing.Point(138, 1);
            this.lbIN3.Name = "lbIN3";
            this.lbIN3.Size = new System.Drawing.Size(42, 24);
            this.lbIN3.TabIndex = 11;
            // 
            // lbIN2
            // 
            this.lbIN2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIN2.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbIN2.Location = new System.Drawing.Point(105, 1);
            this.lbIN2.Name = "lbIN2";
            this.lbIN2.Size = new System.Drawing.Size(42, 24);
            this.lbIN2.TabIndex = 10;
            // 
            // lbIN1
            // 
            this.lbIN1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIN1.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbIN1.Location = new System.Drawing.Point(72, 1);
            this.lbIN1.Name = "lbIN1";
            this.lbIN1.Size = new System.Drawing.Size(42, 24);
            this.lbIN1.TabIndex = 9;
            // 
            // lbIN0
            // 
            this.lbIN0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIN0.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbIN0.Location = new System.Drawing.Point(39, 1);
            this.lbIN0.Name = "lbIN0";
            this.lbIN0.Size = new System.Drawing.Size(42, 24);
            this.lbIN0.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbOUT4);
            this.panel1.Controls.Add(this.lbOUT3);
            this.panel1.Controls.Add(this.lbOUT2);
            this.panel1.Controls.Add(this.lbOUT1);
            this.panel1.Controls.Add(this.lbOUT0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(534, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 27);
            this.panel1.TabIndex = 28;
            // 
            // lbOUT4
            // 
            this.lbOUT4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOUT4.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbOUT4.Location = new System.Drawing.Point(185, 1);
            this.lbOUT4.Name = "lbOUT4";
            this.lbOUT4.Size = new System.Drawing.Size(24, 23);
            this.lbOUT4.TabIndex = 17;
            // 
            // lbOUT3
            // 
            this.lbOUT3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOUT3.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbOUT3.Location = new System.Drawing.Point(151, 1);
            this.lbOUT3.Name = "lbOUT3";
            this.lbOUT3.Size = new System.Drawing.Size(24, 23);
            this.lbOUT3.TabIndex = 16;
            // 
            // lbOUT2
            // 
            this.lbOUT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOUT2.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbOUT2.Location = new System.Drawing.Point(117, 1);
            this.lbOUT2.Name = "lbOUT2";
            this.lbOUT2.Size = new System.Drawing.Size(24, 23);
            this.lbOUT2.TabIndex = 15;
            // 
            // lbOUT1
            // 
            this.lbOUT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOUT1.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbOUT1.Location = new System.Drawing.Point(83, 1);
            this.lbOUT1.Name = "lbOUT1";
            this.lbOUT1.Size = new System.Drawing.Size(24, 23);
            this.lbOUT1.TabIndex = 14;
            // 
            // lbOUT0
            // 
            this.lbOUT0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOUT0.Image = global::barcode_printer.Properties.Resources.gray;
            this.lbOUT0.Location = new System.Drawing.Point(49, 1);
            this.lbOUT0.Name = "lbOUT0";
            this.lbOUT0.Size = new System.Drawing.Size(24, 23);
            this.lbOUT0.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "OUT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_cheksn
            // 
            this.timer_cheksn.Interval = 1000;
            this.timer_cheksn.Tick += new System.EventHandler(this.timer_cheksn_Tick);
            // 
            // timer_check_ready
            // 
            this.timer_check_ready.Enabled = true;
            this.timer_check_ready.Tick += new System.EventHandler(this.timer_check_ready_Tick);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 50;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // echo_msg1
            // 
            this.echo_msg1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.echo_msg1.BackColor = System.Drawing.Color.Transparent;
            this.echo_msg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.echo_msg1.Location = new System.Drawing.Point(1, 496);
            this.echo_msg1.Name = "echo_msg1";
            this.echo_msg1.Size = new System.Drawing.Size(882, 30);
            this.echo_msg1.TabIndex = 35;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.echo_msg1);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.gridEX2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblog);
            this.Controls.Add(this.main_toolstrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签打印软件";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFrm_FormClosing);
            this.Resize += new System.EventHandler(this.mainFrm_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainFrm_KeyDown);
            this.main_toolstrip.ResumeLayout(false);
            this.main_toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX2)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip main_toolstrip;
        private System.Windows.Forms.ToolStripButton toolstrip_codeprint;
        private System.Windows.Forms.ToolStripButton toolstrip_codecheck;
        private System.Windows.Forms.ToolStripButton toolstrp_printtemple;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialport_iotrans;
        private System.Windows.Forms.ToolStripButton manual_print;
        private System.Windows.Forms.Label lblog;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbWarningMsg;
        private System.Windows.Forms.Button btnCancelScan;
        private Janus.Windows.GridEX.GridEX gridEX2;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbIN4;
        private System.Windows.Forms.Label lbIN3;
        private System.Windows.Forms.Label lbIN2;
        private System.Windows.Forms.Label lbIN1;
        private System.Windows.Forms.Label lbIN0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbOUT4;
        private System.Windows.Forms.Label lbOUT3;
        private System.Windows.Forms.Label lbOUT2;
        private System.Windows.Forms.Label lbOUT1;
        private System.Windows.Forms.Label lbOUT0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton page_down;
        private System.Windows.Forms.ToolStripButton page_up;
        private System.IO.Ports.SerialPort serialport_printer;
        private System.Windows.Forms.Timer timer_cheksn;
        private System.Windows.Forms.ToolStripTextBox tbJumpoffset;
        private System.Windows.Forms.ToolStripButton jump_pageoffset;
        private echo_msg echo_msg1;
        private System.Windows.Forms.Timer timer_check_ready;
        private System.Windows.Forms.Label lbLink;
        private System.Windows.Forms.ToolStripButton print_minmax;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lbPrivate;
    }
}

