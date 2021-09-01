namespace RDA5807M_remote
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.COM_groupbox = new System.Windows.Forms.GroupBox();
            this.COMState_label = new System.Windows.Forms.Label();
            this.COMstinfo_label = new System.Windows.Forms.Label();
            this.COMConnectDisconnect_btn = new System.Windows.Forms.Button();
            this.RxTimeoutUnit_label = new System.Windows.Forms.Label();
            this.TxTimeoutUnit_label = new System.Windows.Forms.Label();
            this.RxTimeout_textedit = new System.Windows.Forms.TextBox();
            this.TxTimeout_textedit = new System.Windows.Forms.TextBox();
            this.RxTimeout_label = new System.Windows.Forms.Label();
            this.TxTimeout_label = new System.Windows.Forms.Label();
            this.parity_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.COM_label = new System.Windows.Forms.Label();
            this.parity_combobox = new System.Windows.Forms.ComboBox();
            this.stopbits_combobox = new System.Windows.Forms.ComboBox();
            this.baudrate_combobox = new System.Windows.Forms.ComboBox();
            this.COM_combobox = new System.Windows.Forms.ComboBox();
            this.RDA_groupbox = new System.Windows.Forms.GroupBox();
            this.sendOnChange_lab = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.freqVal_lab = new System.Windows.Forms.Label();
            this.SendOnChange_scrbar = new System.Windows.Forms.HScrollBar();
            this.volumeVal_lab = new System.Windows.Forms.Label();
            this.sendOnChangeVal_lab = new System.Windows.Forms.Label();
            this.freq_textbox = new System.Windows.Forms.TextBox();
            this.Vol_textbox = new System.Windows.Forms.TextBox();
            this.freqencyInfo_label = new System.Windows.Forms.Label();
            this.volume_label = new System.Windows.Forms.Label();
            this.freq_scrollbar = new System.Windows.Forms.HScrollBar();
            this.volume_scrollbar = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chanSpacing_combobox = new System.Windows.Forms.ComboBox();
            this.RDSFIFOdisabledinfo_label = new System.Windows.Forms.Label();
            this.RDSFIFOinfo_label = new System.Windows.Forms.Label();
            this.RDSfifoOnOff_scrollbar = new System.Windows.Forms.HScrollBar();
            this.RDSdisabledinfo_label = new System.Windows.Forms.Label();
            this.RDSinfo_label = new System.Windows.Forms.Label();
            this.RDSonOff_scrbar = new System.Windows.Forms.HScrollBar();
            this.TxRxEvents_lab = new System.Windows.Forms.Label();
            this.RDSmsg_lab = new System.Windows.Forms.Label();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.send_groupbox = new System.Windows.Forms.GroupBox();
            this.COMUARTmsg_richtextbox = new System.Windows.Forms.RichTextBox();
            this.RDSmsg_richtextbox = new System.Windows.Forms.RichTextBox();
            this.read_groupbox = new System.Windows.Forms.GroupBox();
            this.getRSSI_button = new System.Windows.Forms.Button();
            this.COM_groupbox.SuspendLayout();
            this.RDA_groupbox.SuspendLayout();
            this.send_groupbox.SuspendLayout();
            this.read_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // COM_groupbox
            // 
            this.COM_groupbox.Controls.Add(this.COMState_label);
            this.COM_groupbox.Controls.Add(this.COMstinfo_label);
            this.COM_groupbox.Controls.Add(this.COMConnectDisconnect_btn);
            this.COM_groupbox.Controls.Add(this.RxTimeoutUnit_label);
            this.COM_groupbox.Controls.Add(this.TxTimeoutUnit_label);
            this.COM_groupbox.Controls.Add(this.RxTimeout_textedit);
            this.COM_groupbox.Controls.Add(this.TxTimeout_textedit);
            this.COM_groupbox.Controls.Add(this.RxTimeout_label);
            this.COM_groupbox.Controls.Add(this.TxTimeout_label);
            this.COM_groupbox.Controls.Add(this.parity_label);
            this.COM_groupbox.Controls.Add(this.stopbits_label);
            this.COM_groupbox.Controls.Add(this.baudrate_label);
            this.COM_groupbox.Controls.Add(this.COM_label);
            this.COM_groupbox.Controls.Add(this.parity_combobox);
            this.COM_groupbox.Controls.Add(this.stopbits_combobox);
            this.COM_groupbox.Controls.Add(this.baudrate_combobox);
            this.COM_groupbox.Controls.Add(this.COM_combobox);
            this.COM_groupbox.Location = new System.Drawing.Point(22, 55);
            this.COM_groupbox.Name = "COM_groupbox";
            this.COM_groupbox.Size = new System.Drawing.Size(406, 186);
            this.COM_groupbox.TabIndex = 0;
            this.COM_groupbox.TabStop = false;
            this.COM_groupbox.Text = "COM settings";
            // 
            // COMState_label
            // 
            this.COMState_label.AutoSize = true;
            this.COMState_label.Location = new System.Drawing.Point(267, 156);
            this.COMState_label.Name = "COMState_label";
            this.COMState_label.Size = new System.Drawing.Size(66, 17);
            this.COMState_label.TabIndex = 39;
            this.COMState_label.Text = "Unknown";
            // 
            // COMstinfo_label
            // 
            this.COMstinfo_label.AutoSize = true;
            this.COMstinfo_label.Location = new System.Drawing.Point(209, 156);
            this.COMstinfo_label.Name = "COMstinfo_label";
            this.COMstinfo_label.Size = new System.Drawing.Size(45, 17);
            this.COMstinfo_label.TabIndex = 38;
            this.COMstinfo_label.Text = "State:";
            // 
            // COMConnectDisconnect_btn
            // 
            this.COMConnectDisconnect_btn.Location = new System.Drawing.Point(212, 108);
            this.COMConnectDisconnect_btn.Name = "COMConnectDisconnect_btn";
            this.COMConnectDisconnect_btn.Size = new System.Drawing.Size(154, 30);
            this.COMConnectDisconnect_btn.TabIndex = 16;
            this.COMConnectDisconnect_btn.Text = "Connect/Disconnect";
            this.COMConnectDisconnect_btn.UseVisualStyleBackColor = true;
            this.COMConnectDisconnect_btn.Click += new System.EventHandler(this.COMConnectDisconnect_btn_Click);
            // 
            // RxTimeoutUnit_label
            // 
            this.RxTimeoutUnit_label.AutoSize = true;
            this.RxTimeoutUnit_label.Location = new System.Drawing.Point(371, 70);
            this.RxTimeoutUnit_label.Name = "RxTimeoutUnit_label";
            this.RxTimeoutUnit_label.Size = new System.Drawing.Size(26, 17);
            this.RxTimeoutUnit_label.TabIndex = 37;
            this.RxTimeoutUnit_label.Text = "ms";
            // 
            // TxTimeoutUnit_label
            // 
            this.TxTimeoutUnit_label.AutoSize = true;
            this.TxTimeoutUnit_label.Location = new System.Drawing.Point(371, 29);
            this.TxTimeoutUnit_label.Name = "TxTimeoutUnit_label";
            this.TxTimeoutUnit_label.Size = new System.Drawing.Size(26, 17);
            this.TxTimeoutUnit_label.TabIndex = 36;
            this.TxTimeoutUnit_label.Text = "ms";
            // 
            // RxTimeout_textedit
            // 
            this.RxTimeout_textedit.Location = new System.Drawing.Point(291, 67);
            this.RxTimeout_textedit.Name = "RxTimeout_textedit";
            this.RxTimeout_textedit.Size = new System.Drawing.Size(74, 22);
            this.RxTimeout_textedit.TabIndex = 35;
            this.RxTimeout_textedit.Text = "100";
            // 
            // TxTimeout_textedit
            // 
            this.TxTimeout_textedit.Location = new System.Drawing.Point(291, 27);
            this.TxTimeout_textedit.Name = "TxTimeout_textedit";
            this.TxTimeout_textedit.Size = new System.Drawing.Size(74, 22);
            this.TxTimeout_textedit.TabIndex = 24;
            this.TxTimeout_textedit.Text = "100";
            // 
            // RxTimeout_label
            // 
            this.RxTimeout_label.AutoSize = true;
            this.RxTimeout_label.Location = new System.Drawing.Point(206, 70);
            this.RxTimeout_label.Name = "RxTimeout_label";
            this.RxTimeout_label.Size = new System.Drawing.Size(79, 17);
            this.RxTimeout_label.TabIndex = 34;
            this.RxTimeout_label.Text = "Rx Timeout";
            // 
            // TxTimeout_label
            // 
            this.TxTimeout_label.AutoSize = true;
            this.TxTimeout_label.Location = new System.Drawing.Point(206, 30);
            this.TxTimeout_label.Name = "TxTimeout_label";
            this.TxTimeout_label.Size = new System.Drawing.Size(78, 17);
            this.TxTimeout_label.TabIndex = 32;
            this.TxTimeout_label.Text = "Tx Timeout";
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Location = new System.Drawing.Point(23, 159);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(44, 17);
            this.parity_label.TabIndex = 30;
            this.parity_label.Text = "Parity";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Location = new System.Drawing.Point(15, 115);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(60, 17);
            this.stopbits_label.TabIndex = 29;
            this.stopbits_label.Text = "StopBits";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(8, 73);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(71, 17);
            this.baudrate_label.TabIndex = 28;
            this.baudrate_label.Text = "BaudRate";
            this.baudrate_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // COM_label
            // 
            this.COM_label.AutoSize = true;
            this.COM_label.Location = new System.Drawing.Point(20, 33);
            this.COM_label.Name = "COM_label";
            this.COM_label.Size = new System.Drawing.Size(39, 17);
            this.COM_label.TabIndex = 24;
            this.COM_label.Text = "COM";
            // 
            // parity_combobox
            // 
            this.parity_combobox.FormattingEnabled = true;
            this.parity_combobox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parity_combobox.Location = new System.Drawing.Point(81, 156);
            this.parity_combobox.Name = "parity_combobox";
            this.parity_combobox.Size = new System.Drawing.Size(91, 24);
            this.parity_combobox.TabIndex = 27;
            // 
            // stopbits_combobox
            // 
            this.stopbits_combobox.FormattingEnabled = true;
            this.stopbits_combobox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopbits_combobox.Location = new System.Drawing.Point(81, 112);
            this.stopbits_combobox.Name = "stopbits_combobox";
            this.stopbits_combobox.Size = new System.Drawing.Size(91, 24);
            this.stopbits_combobox.TabIndex = 26;
            // 
            // baudrate_combobox
            // 
            this.baudrate_combobox.FormattingEnabled = true;
            this.baudrate_combobox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.baudrate_combobox.Location = new System.Drawing.Point(81, 70);
            this.baudrate_combobox.Name = "baudrate_combobox";
            this.baudrate_combobox.Size = new System.Drawing.Size(91, 24);
            this.baudrate_combobox.TabIndex = 25;
            // 
            // COM_combobox
            // 
            this.COM_combobox.FormattingEnabled = true;
            this.COM_combobox.Location = new System.Drawing.Point(81, 30);
            this.COM_combobox.Name = "COM_combobox";
            this.COM_combobox.Size = new System.Drawing.Size(91, 24);
            this.COM_combobox.TabIndex = 24;
            this.COM_combobox.Click += new System.EventHandler(this.COM_combobox_Clicked);
            // 
            // RDA_groupbox
            // 
            this.RDA_groupbox.Controls.Add(this.sendOnChange_lab);
            this.RDA_groupbox.Controls.Add(this.send_btn);
            this.RDA_groupbox.Controls.Add(this.freqVal_lab);
            this.RDA_groupbox.Controls.Add(this.SendOnChange_scrbar);
            this.RDA_groupbox.Controls.Add(this.volumeVal_lab);
            this.RDA_groupbox.Controls.Add(this.sendOnChangeVal_lab);
            this.RDA_groupbox.Controls.Add(this.freq_textbox);
            this.RDA_groupbox.Controls.Add(this.Vol_textbox);
            this.RDA_groupbox.Controls.Add(this.freqencyInfo_label);
            this.RDA_groupbox.Controls.Add(this.volume_label);
            this.RDA_groupbox.Controls.Add(this.freq_scrollbar);
            this.RDA_groupbox.Controls.Add(this.volume_scrollbar);
            this.RDA_groupbox.Location = new System.Drawing.Point(22, 247);
            this.RDA_groupbox.Name = "RDA_groupbox";
            this.RDA_groupbox.Size = new System.Drawing.Size(406, 215);
            this.RDA_groupbox.TabIndex = 1;
            this.RDA_groupbox.TabStop = false;
            this.RDA_groupbox.Text = "RDA5807 control";
            // 
            // sendOnChange_lab
            // 
            this.sendOnChange_lab.AutoSize = true;
            this.sendOnChange_lab.Location = new System.Drawing.Point(276, 140);
            this.sendOnChange_lab.Name = "sendOnChange_lab";
            this.sendOnChange_lab.Size = new System.Drawing.Size(112, 17);
            this.sendOnChange_lab.TabIndex = 13;
            this.sendOnChange_lab.Text = "Send on change";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(55, 157);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(144, 26);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // freqVal_lab
            // 
            this.freqVal_lab.AutoSize = true;
            this.freqVal_lab.Location = new System.Drawing.Point(327, 77);
            this.freqVal_lab.Name = "freqVal_lab";
            this.freqVal_lab.Size = new System.Drawing.Size(40, 17);
            this.freqVal_lab.TabIndex = 11;
            this.freqVal_lab.Text = " MHz";
            // 
            // SendOnChange_scrbar
            // 
            this.SendOnChange_scrbar.LargeChange = 1;
            this.SendOnChange_scrbar.Location = new System.Drawing.Point(279, 157);
            this.SendOnChange_scrbar.Maximum = 1;
            this.SendOnChange_scrbar.Name = "SendOnChange_scrbar";
            this.SendOnChange_scrbar.Size = new System.Drawing.Size(109, 26);
            this.SendOnChange_scrbar.TabIndex = 12;
            this.SendOnChange_scrbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SendOnChange_scrbar_Scroll);
            // 
            // volumeVal_lab
            // 
            this.volumeVal_lab.AutoSize = true;
            this.volumeVal_lab.Location = new System.Drawing.Point(323, 29);
            this.volumeVal_lab.Name = "volumeVal_lab";
            this.volumeVal_lab.Size = new System.Drawing.Size(50, 17);
            this.volumeVal_lab.TabIndex = 10;
            this.volumeVal_lab.Text = " val/15";
            // 
            // sendOnChangeVal_lab
            // 
            this.sendOnChangeVal_lab.AutoSize = true;
            this.sendOnChangeVal_lab.Location = new System.Drawing.Point(299, 187);
            this.sendOnChangeVal_lab.Name = "sendOnChangeVal_lab";
            this.sendOnChangeVal_lab.Size = new System.Drawing.Size(63, 17);
            this.sendOnChangeVal_lab.TabIndex = 14;
            this.sendOnChangeVal_lab.Text = "Disabled";
            // 
            // freq_textbox
            // 
            this.freq_textbox.Location = new System.Drawing.Point(314, 94);
            this.freq_textbox.Name = "freq_textbox";
            this.freq_textbox.ReadOnly = true;
            this.freq_textbox.Size = new System.Drawing.Size(74, 22);
            this.freq_textbox.TabIndex = 9;
            this.freq_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vol_textbox
            // 
            this.Vol_textbox.Location = new System.Drawing.Point(314, 46);
            this.Vol_textbox.Name = "Vol_textbox";
            this.Vol_textbox.ReadOnly = true;
            this.Vol_textbox.Size = new System.Drawing.Size(74, 22);
            this.Vol_textbox.TabIndex = 8;
            this.Vol_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freqencyInfo_label
            // 
            this.freqencyInfo_label.AutoSize = true;
            this.freqencyInfo_label.Location = new System.Drawing.Point(106, 77);
            this.freqencyInfo_label.Name = "freqencyInfo_label";
            this.freqencyInfo_label.Size = new System.Drawing.Size(75, 17);
            this.freqencyInfo_label.TabIndex = 7;
            this.freqencyInfo_label.Text = "Frequency";
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(117, 29);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(55, 17);
            this.volume_label.TabIndex = 6;
            this.volume_label.Text = "Volume";
            // 
            // freq_scrollbar
            // 
            this.freq_scrollbar.LargeChange = 1;
            this.freq_scrollbar.Location = new System.Drawing.Point(26, 94);
            this.freq_scrollbar.Maximum = 1080;
            this.freq_scrollbar.Minimum = 760;
            this.freq_scrollbar.Name = "freq_scrollbar";
            this.freq_scrollbar.Size = new System.Drawing.Size(258, 26);
            this.freq_scrollbar.TabIndex = 1;
            this.freq_scrollbar.Value = 922;
            this.freq_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.freq_scrollbar_Scroll);
            // 
            // volume_scrollbar
            // 
            this.volume_scrollbar.LargeChange = 1;
            this.volume_scrollbar.Location = new System.Drawing.Point(26, 46);
            this.volume_scrollbar.Maximum = 15;
            this.volume_scrollbar.Name = "volume_scrollbar";
            this.volume_scrollbar.Size = new System.Drawing.Size(258, 26);
            this.volume_scrollbar.TabIndex = 0;
            this.volume_scrollbar.Value = 7;
            this.volume_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_scrollbar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "spacing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Channel";
            // 
            // chanSpacing_combobox
            // 
            this.chanSpacing_combobox.FormattingEnabled = true;
            this.chanSpacing_combobox.Items.AddRange(new object[] {
            "50 kHz",
            "100 kHz",
            "200 kHz"});
            this.chanSpacing_combobox.Location = new System.Drawing.Point(282, 76);
            this.chanSpacing_combobox.Name = "chanSpacing_combobox";
            this.chanSpacing_combobox.Size = new System.Drawing.Size(91, 24);
            this.chanSpacing_combobox.TabIndex = 21;
            // 
            // RDSFIFOdisabledinfo_label
            // 
            this.RDSFIFOdisabledinfo_label.AutoSize = true;
            this.RDSFIFOdisabledinfo_label.Location = new System.Drawing.Point(177, 83);
            this.RDSFIFOdisabledinfo_label.Name = "RDSFIFOdisabledinfo_label";
            this.RDSFIFOdisabledinfo_label.Size = new System.Drawing.Size(63, 17);
            this.RDSFIFOdisabledinfo_label.TabIndex = 20;
            this.RDSFIFOdisabledinfo_label.Text = "Disabled";
            // 
            // RDSFIFOinfo_label
            // 
            this.RDSFIFOinfo_label.AutoSize = true;
            this.RDSFIFOinfo_label.Location = new System.Drawing.Point(169, 23);
            this.RDSFIFOinfo_label.Name = "RDSFIFOinfo_label";
            this.RDSFIFOinfo_label.Size = new System.Drawing.Size(71, 17);
            this.RDSFIFOinfo_label.TabIndex = 19;
            this.RDSFIFOinfo_label.Text = "RDS FIFO";
            // 
            // RDSfifoOnOff_scrollbar
            // 
            this.RDSfifoOnOff_scrollbar.LargeChange = 1;
            this.RDSfifoOnOff_scrollbar.Location = new System.Drawing.Point(145, 44);
            this.RDSfifoOnOff_scrollbar.Maximum = 1;
            this.RDSfifoOnOff_scrollbar.Name = "RDSfifoOnOff_scrollbar";
            this.RDSfifoOnOff_scrollbar.Size = new System.Drawing.Size(109, 26);
            this.RDSfifoOnOff_scrollbar.TabIndex = 18;
            this.RDSfifoOnOff_scrollbar.Value = 1;
            // 
            // RDSdisabledinfo_label
            // 
            this.RDSdisabledinfo_label.AutoSize = true;
            this.RDSdisabledinfo_label.Location = new System.Drawing.Point(47, 83);
            this.RDSdisabledinfo_label.Name = "RDSdisabledinfo_label";
            this.RDSdisabledinfo_label.Size = new System.Drawing.Size(63, 17);
            this.RDSdisabledinfo_label.TabIndex = 17;
            this.RDSdisabledinfo_label.Text = "Disabled";
            // 
            // RDSinfo_label
            // 
            this.RDSinfo_label.AutoSize = true;
            this.RDSinfo_label.Location = new System.Drawing.Point(52, 23);
            this.RDSinfo_label.Name = "RDSinfo_label";
            this.RDSinfo_label.Size = new System.Drawing.Size(37, 17);
            this.RDSinfo_label.TabIndex = 16;
            this.RDSinfo_label.Text = "RDS";
            // 
            // RDSonOff_scrbar
            // 
            this.RDSonOff_scrbar.LargeChange = 1;
            this.RDSonOff_scrbar.Location = new System.Drawing.Point(18, 44);
            this.RDSonOff_scrbar.Maximum = 1;
            this.RDSonOff_scrbar.Name = "RDSonOff_scrbar";
            this.RDSonOff_scrbar.Size = new System.Drawing.Size(109, 26);
            this.RDSonOff_scrbar.TabIndex = 15;
            this.RDSonOff_scrbar.Value = 1;
            // 
            // TxRxEvents_lab
            // 
            this.TxRxEvents_lab.AutoSize = true;
            this.TxRxEvents_lab.Location = new System.Drawing.Point(526, 35);
            this.TxRxEvents_lab.Name = "TxRxEvents_lab";
            this.TxRxEvents_lab.Size = new System.Drawing.Size(194, 17);
            this.TxRxEvents_lab.TabIndex = 4;
            this.TxRxEvents_lab.Text = "COM events and UART TxRx ";
            // 
            // RDSmsg_lab
            // 
            this.RDSmsg_lab.AutoSize = true;
            this.RDSmsg_lab.Location = new System.Drawing.Point(959, 35);
            this.RDSmsg_lab.Name = "RDSmsg_lab";
            this.RDSmsg_lab.Size = new System.Drawing.Size(105, 17);
            this.RDSmsg_lab.TabIndex = 5;
            this.RDSmsg_lab.Text = "RDS messages";
            // 
            // send_groupbox
            // 
            this.send_groupbox.Controls.Add(this.label6);
            this.send_groupbox.Controls.Add(this.label5);
            this.send_groupbox.Controls.Add(this.chanSpacing_combobox);
            this.send_groupbox.Controls.Add(this.RDSonOff_scrbar);
            this.send_groupbox.Controls.Add(this.RDSFIFOdisabledinfo_label);
            this.send_groupbox.Controls.Add(this.RDSfifoOnOff_scrollbar);
            this.send_groupbox.Controls.Add(this.RDSFIFOinfo_label);
            this.send_groupbox.Controls.Add(this.RDSinfo_label);
            this.send_groupbox.Controls.Add(this.RDSdisabledinfo_label);
            this.send_groupbox.Location = new System.Drawing.Point(22, 468);
            this.send_groupbox.Name = "send_groupbox";
            this.send_groupbox.Size = new System.Drawing.Size(406, 113);
            this.send_groupbox.TabIndex = 1;
            this.send_groupbox.TabStop = false;
            this.send_groupbox.Text = "Send control";
            // 
            // COMUARTmsg_richtextbox
            // 
            this.COMUARTmsg_richtextbox.Location = new System.Drawing.Point(469, 67);
            this.COMUARTmsg_richtextbox.Name = "COMUARTmsg_richtextbox";
            this.COMUARTmsg_richtextbox.Size = new System.Drawing.Size(354, 633);
            this.COMUARTmsg_richtextbox.TabIndex = 6;
            this.COMUARTmsg_richtextbox.Text = "";
            // 
            // RDSmsg_richtextbox
            // 
            this.RDSmsg_richtextbox.Location = new System.Drawing.Point(829, 67);
            this.RDSmsg_richtextbox.Name = "RDSmsg_richtextbox";
            this.RDSmsg_richtextbox.Size = new System.Drawing.Size(365, 633);
            this.RDSmsg_richtextbox.TabIndex = 7;
            this.RDSmsg_richtextbox.Text = "";
            // 
            // read_groupbox
            // 
            this.read_groupbox.Controls.Add(this.getRSSI_button);
            this.read_groupbox.Location = new System.Drawing.Point(22, 587);
            this.read_groupbox.Name = "read_groupbox";
            this.read_groupbox.Size = new System.Drawing.Size(406, 113);
            this.read_groupbox.TabIndex = 24;
            this.read_groupbox.TabStop = false;
            this.read_groupbox.Text = "Read control";
            // 
            // getRSSI_button
            // 
            this.getRSSI_button.Location = new System.Drawing.Point(14, 43);
            this.getRSSI_button.Name = "getRSSI_button";
            this.getRSSI_button.Size = new System.Drawing.Size(85, 34);
            this.getRSSI_button.TabIndex = 0;
            this.getRSSI_button.Text = "Get RSSI";
            this.getRSSI_button.UseVisualStyleBackColor = true;
            this.getRSSI_button.Click += new System.EventHandler(this.getRSSI_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 721);
            this.Controls.Add(this.read_groupbox);
            this.Controls.Add(this.RDSmsg_richtextbox);
            this.Controls.Add(this.COMUARTmsg_richtextbox);
            this.Controls.Add(this.send_groupbox);
            this.Controls.Add(this.RDSmsg_lab);
            this.Controls.Add(this.TxRxEvents_lab);
            this.Controls.Add(this.RDA_groupbox);
            this.Controls.Add(this.COM_groupbox);
            this.Name = "MainForm";
            this.Text = "RDA5807M Control/View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.COM_groupbox.ResumeLayout(false);
            this.COM_groupbox.PerformLayout();
            this.RDA_groupbox.ResumeLayout(false);
            this.RDA_groupbox.PerformLayout();
            this.send_groupbox.ResumeLayout(false);
            this.send_groupbox.PerformLayout();
            this.read_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox COM_groupbox;
        private System.Windows.Forms.GroupBox RDA_groupbox;
        private System.Windows.Forms.Label TxRxEvents_lab;
        private System.Windows.Forms.Label RDSmsg_lab;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.TextBox Vol_textbox;
        private System.Windows.Forms.Label freqencyInfo_label;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.HScrollBar freq_scrollbar;
        private System.Windows.Forms.HScrollBar volume_scrollbar;
        private System.Windows.Forms.TextBox freq_textbox;
        private System.Windows.Forms.Label freqVal_lab;
        private System.Windows.Forms.Label volumeVal_lab;
        private System.Windows.Forms.HScrollBar SendOnChange_scrbar;
        private System.Windows.Forms.Label sendOnChangeVal_lab;
        private System.Windows.Forms.Label sendOnChange_lab;
        private System.Windows.Forms.Label RDSdisabledinfo_label;
        private System.Windows.Forms.Label RDSinfo_label;
        private System.Windows.Forms.HScrollBar RDSonOff_scrbar;
        private System.Windows.Forms.GroupBox send_groupbox;
        private System.Windows.Forms.Label RDSFIFOdisabledinfo_label;
        private System.Windows.Forms.Label RDSFIFOinfo_label;
        private System.Windows.Forms.HScrollBar RDSfifoOnOff_scrollbar;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chanSpacing_combobox;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.Label COM_label;
        private System.Windows.Forms.ComboBox parity_combobox;
        private System.Windows.Forms.ComboBox stopbits_combobox;
        private System.Windows.Forms.ComboBox baudrate_combobox;
        private System.Windows.Forms.ComboBox COM_combobox;
        private System.Windows.Forms.Label COMState_label;
        private System.Windows.Forms.Label COMstinfo_label;
        private System.Windows.Forms.Button COMConnectDisconnect_btn;
        private System.Windows.Forms.Label RxTimeoutUnit_label;
        private System.Windows.Forms.Label TxTimeoutUnit_label;
        private System.Windows.Forms.TextBox RxTimeout_textedit;
        private System.Windows.Forms.TextBox TxTimeout_textedit;
        private System.Windows.Forms.Label RxTimeout_label;
        private System.Windows.Forms.Label TxTimeout_label;
        private System.Windows.Forms.RichTextBox COMUARTmsg_richtextbox;
        private System.Windows.Forms.RichTextBox RDSmsg_richtextbox;
        private System.Windows.Forms.GroupBox read_groupbox;
        private System.Windows.Forms.Button getRSSI_button;
    }
}

