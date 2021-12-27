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
            this.mute_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.init_button = new System.Windows.Forms.Button();
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
            this.TxRxEvents_lab = new System.Windows.Forms.Label();
            this.RDSmsg_lab = new System.Windows.Forms.Label();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.COMUARTmsg_richtextbox = new System.Windows.Forms.RichTextBox();
            this.RDSmsg_richtextbox = new System.Windows.Forms.RichTextBox();
            this.read_groupbox = new System.Windows.Forms.GroupBox();
            this.OFF_lab = new System.Windows.Forms.Label();
            this.ON_lab = new System.Windows.Forms.Label();
            this.PeriodRead_lab = new System.Windows.Forms.Label();
            this.chst_val_lab = new System.Windows.Forms.Label();
            this.stro_val_lab = new System.Windows.Forms.Label();
            this.rdsr_val_lab = new System.Windows.Forms.Label();
            this.rdss_val_lab = new System.Windows.Forms.Label();
            this.rssi_val_lab = new System.Windows.Forms.Label();
            this.chs_scrollbar = new System.Windows.Forms.VScrollBar();
            this.chst_button = new System.Windows.Forms.Button();
            this.str_scrollbar = new System.Windows.Forms.VScrollBar();
            this.stro_button = new System.Windows.Forms.Button();
            this.rdsr_scrollbar = new System.Windows.Forms.VScrollBar();
            this.rdsr_button = new System.Windows.Forms.Button();
            this.rdss_button = new System.Windows.Forms.Button();
            this.rds_scrollbar = new System.Windows.Forms.VScrollBar();
            this.rssi_scrollbar = new System.Windows.Forms.VScrollBar();
            this.rssi_button = new System.Windows.Forms.Button();
            this.getBLKA_button = new System.Windows.Forms.Button();
            this.getBLKB_button = new System.Windows.Forms.Button();
            this.getBLKC_button = new System.Windows.Forms.Button();
            this.getBLKD_button = new System.Windows.Forms.Button();
            this.COM_groupbox.SuspendLayout();
            this.RDA_groupbox.SuspendLayout();
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
            this.COM_groupbox.Location = new System.Drawing.Point(25, 54);
            this.COM_groupbox.Margin = new System.Windows.Forms.Padding(2);
            this.COM_groupbox.Name = "COM_groupbox";
            this.COM_groupbox.Padding = new System.Windows.Forms.Padding(2);
            this.COM_groupbox.Size = new System.Drawing.Size(343, 151);
            this.COM_groupbox.TabIndex = 0;
            this.COM_groupbox.TabStop = false;
            this.COM_groupbox.Text = "COM settings";
            // 
            // COMState_label
            // 
            this.COMState_label.AutoSize = true;
            this.COMState_label.Location = new System.Drawing.Point(227, 127);
            this.COMState_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COMState_label.Name = "COMState_label";
            this.COMState_label.Size = new System.Drawing.Size(53, 13);
            this.COMState_label.TabIndex = 39;
            this.COMState_label.Text = "Unknown";
            // 
            // COMstinfo_label
            // 
            this.COMstinfo_label.AutoSize = true;
            this.COMstinfo_label.Location = new System.Drawing.Point(184, 127);
            this.COMstinfo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COMstinfo_label.Name = "COMstinfo_label";
            this.COMstinfo_label.Size = new System.Drawing.Size(35, 13);
            this.COMstinfo_label.TabIndex = 38;
            this.COMstinfo_label.Text = "State:";
            // 
            // COMConnectDisconnect_btn
            // 
            this.COMConnectDisconnect_btn.Location = new System.Drawing.Point(186, 88);
            this.COMConnectDisconnect_btn.Margin = new System.Windows.Forms.Padding(2);
            this.COMConnectDisconnect_btn.Name = "COMConnectDisconnect_btn";
            this.COMConnectDisconnect_btn.Size = new System.Drawing.Size(116, 24);
            this.COMConnectDisconnect_btn.TabIndex = 16;
            this.COMConnectDisconnect_btn.Text = "Connect/Disconnect";
            this.COMConnectDisconnect_btn.UseVisualStyleBackColor = true;
            this.COMConnectDisconnect_btn.Click += new System.EventHandler(this.COMConnectDisconnect_btn_Click);
            // 
            // RxTimeoutUnit_label
            // 
            this.RxTimeoutUnit_label.AutoSize = true;
            this.RxTimeoutUnit_label.Location = new System.Drawing.Point(305, 57);
            this.RxTimeoutUnit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RxTimeoutUnit_label.Name = "RxTimeoutUnit_label";
            this.RxTimeoutUnit_label.Size = new System.Drawing.Size(20, 13);
            this.RxTimeoutUnit_label.TabIndex = 37;
            this.RxTimeoutUnit_label.Text = "ms";
            // 
            // TxTimeoutUnit_label
            // 
            this.TxTimeoutUnit_label.AutoSize = true;
            this.TxTimeoutUnit_label.Location = new System.Drawing.Point(305, 24);
            this.TxTimeoutUnit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxTimeoutUnit_label.Name = "TxTimeoutUnit_label";
            this.TxTimeoutUnit_label.Size = new System.Drawing.Size(20, 13);
            this.TxTimeoutUnit_label.TabIndex = 36;
            this.TxTimeoutUnit_label.Text = "ms";
            // 
            // RxTimeout_textedit
            // 
            this.RxTimeout_textedit.Location = new System.Drawing.Point(245, 54);
            this.RxTimeout_textedit.Margin = new System.Windows.Forms.Padding(2);
            this.RxTimeout_textedit.Name = "RxTimeout_textedit";
            this.RxTimeout_textedit.Size = new System.Drawing.Size(56, 20);
            this.RxTimeout_textedit.TabIndex = 35;
            this.RxTimeout_textedit.Text = "100";
            // 
            // TxTimeout_textedit
            // 
            this.TxTimeout_textedit.Location = new System.Drawing.Point(245, 22);
            this.TxTimeout_textedit.Margin = new System.Windows.Forms.Padding(2);
            this.TxTimeout_textedit.Name = "TxTimeout_textedit";
            this.TxTimeout_textedit.Size = new System.Drawing.Size(56, 20);
            this.TxTimeout_textedit.TabIndex = 24;
            this.TxTimeout_textedit.Text = "100";
            // 
            // RxTimeout_label
            // 
            this.RxTimeout_label.AutoSize = true;
            this.RxTimeout_label.Location = new System.Drawing.Point(181, 57);
            this.RxTimeout_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RxTimeout_label.Name = "RxTimeout_label";
            this.RxTimeout_label.Size = new System.Drawing.Size(61, 13);
            this.RxTimeout_label.TabIndex = 34;
            this.RxTimeout_label.Text = "Rx Timeout";
            // 
            // TxTimeout_label
            // 
            this.TxTimeout_label.AutoSize = true;
            this.TxTimeout_label.Location = new System.Drawing.Point(181, 24);
            this.TxTimeout_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxTimeout_label.Name = "TxTimeout_label";
            this.TxTimeout_label.Size = new System.Drawing.Size(60, 13);
            this.TxTimeout_label.TabIndex = 32;
            this.TxTimeout_label.Text = "Tx Timeout";
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Location = new System.Drawing.Point(17, 129);
            this.parity_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(33, 13);
            this.parity_label.TabIndex = 30;
            this.parity_label.Text = "Parity";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Location = new System.Drawing.Point(11, 93);
            this.stopbits_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(46, 13);
            this.stopbits_label.TabIndex = 29;
            this.stopbits_label.Text = "StopBits";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(6, 59);
            this.baudrate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(55, 13);
            this.baudrate_label.TabIndex = 28;
            this.baudrate_label.Text = "BaudRate";
            this.baudrate_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // COM_label
            // 
            this.COM_label.AutoSize = true;
            this.COM_label.Location = new System.Drawing.Point(15, 27);
            this.COM_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COM_label.Name = "COM_label";
            this.COM_label.Size = new System.Drawing.Size(31, 13);
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
            this.parity_combobox.Location = new System.Drawing.Point(80, 127);
            this.parity_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.parity_combobox.Name = "parity_combobox";
            this.parity_combobox.Size = new System.Drawing.Size(69, 21);
            this.parity_combobox.TabIndex = 27;
            // 
            // stopbits_combobox
            // 
            this.stopbits_combobox.FormattingEnabled = true;
            this.stopbits_combobox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopbits_combobox.Location = new System.Drawing.Point(80, 91);
            this.stopbits_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.stopbits_combobox.Name = "stopbits_combobox";
            this.stopbits_combobox.Size = new System.Drawing.Size(69, 21);
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
            this.baudrate_combobox.Location = new System.Drawing.Point(80, 57);
            this.baudrate_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.baudrate_combobox.Name = "baudrate_combobox";
            this.baudrate_combobox.Size = new System.Drawing.Size(69, 21);
            this.baudrate_combobox.TabIndex = 25;
            // 
            // COM_combobox
            // 
            this.COM_combobox.FormattingEnabled = true;
            this.COM_combobox.Location = new System.Drawing.Point(80, 24);
            this.COM_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.COM_combobox.Name = "COM_combobox";
            this.COM_combobox.Size = new System.Drawing.Size(69, 21);
            this.COM_combobox.TabIndex = 24;
            this.COM_combobox.Click += new System.EventHandler(this.COM_combobox_Clicked);
            // 
            // RDA_groupbox
            // 
            this.RDA_groupbox.Controls.Add(this.mute_button);
            this.RDA_groupbox.Controls.Add(this.reset_button);
            this.RDA_groupbox.Controls.Add(this.init_button);
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
            this.RDA_groupbox.Location = new System.Drawing.Point(25, 210);
            this.RDA_groupbox.Margin = new System.Windows.Forms.Padding(2);
            this.RDA_groupbox.Name = "RDA_groupbox";
            this.RDA_groupbox.Padding = new System.Windows.Forms.Padding(2);
            this.RDA_groupbox.Size = new System.Drawing.Size(343, 242);
            this.RDA_groupbox.TabIndex = 1;
            this.RDA_groupbox.TabStop = false;
            this.RDA_groupbox.Text = "RDA5807 control";
            // 
            // mute_button
            // 
            this.mute_button.Location = new System.Drawing.Point(26, 205);
            this.mute_button.Margin = new System.Windows.Forms.Padding(2);
            this.mute_button.Name = "mute_button";
            this.mute_button.Size = new System.Drawing.Size(108, 21);
            this.mute_button.TabIndex = 18;
            this.mute_button.Text = "Mute";
            this.mute_button.UseVisualStyleBackColor = true;
            this.mute_button.Click += new System.EventHandler(this.mute_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(188, 38);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(108, 21);
            this.reset_button.TabIndex = 17;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // init_button
            // 
            this.init_button.Location = new System.Drawing.Point(26, 39);
            this.init_button.Margin = new System.Windows.Forms.Padding(2);
            this.init_button.Name = "init_button";
            this.init_button.Size = new System.Drawing.Size(108, 21);
            this.init_button.TabIndex = 16;
            this.init_button.Text = "Initialize";
            this.init_button.UseVisualStyleBackColor = true;
            this.init_button.Click += new System.EventHandler(this.init_button_Click);
            // 
            // sendOnChange_lab
            // 
            this.sendOnChange_lab.AutoSize = true;
            this.sendOnChange_lab.Location = new System.Drawing.Point(228, 166);
            this.sendOnChange_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendOnChange_lab.Name = "sendOnChange_lab";
            this.sendOnChange_lab.Size = new System.Drawing.Size(86, 13);
            this.sendOnChange_lab.TabIndex = 13;
            this.sendOnChange_lab.Text = "Send on change";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(26, 167);
            this.send_btn.Margin = new System.Windows.Forms.Padding(2);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(108, 21);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "Send (Vol, Freq)";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // freqVal_lab
            // 
            this.freqVal_lab.AutoSize = true;
            this.freqVal_lab.Location = new System.Drawing.Point(266, 114);
            this.freqVal_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.freqVal_lab.Name = "freqVal_lab";
            this.freqVal_lab.Size = new System.Drawing.Size(32, 13);
            this.freqVal_lab.TabIndex = 11;
            this.freqVal_lab.Text = " MHz";
            // 
            // SendOnChange_scrbar
            // 
            this.SendOnChange_scrbar.LargeChange = 1;
            this.SendOnChange_scrbar.Location = new System.Drawing.Point(230, 179);
            this.SendOnChange_scrbar.Maximum = 1;
            this.SendOnChange_scrbar.Name = "SendOnChange_scrbar";
            this.SendOnChange_scrbar.Size = new System.Drawing.Size(82, 26);
            this.SendOnChange_scrbar.TabIndex = 12;
            this.SendOnChange_scrbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SendOnChange_scrbar_Scroll);
            // 
            // volumeVal_lab
            // 
            this.volumeVal_lab.AutoSize = true;
            this.volumeVal_lab.Location = new System.Drawing.Point(263, 75);
            this.volumeVal_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volumeVal_lab.Name = "volumeVal_lab";
            this.volumeVal_lab.Size = new System.Drawing.Size(41, 13);
            this.volumeVal_lab.TabIndex = 10;
            this.volumeVal_lab.Text = " val/15";
            // 
            // sendOnChangeVal_lab
            // 
            this.sendOnChangeVal_lab.AutoSize = true;
            this.sendOnChangeVal_lab.Location = new System.Drawing.Point(245, 204);
            this.sendOnChangeVal_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendOnChangeVal_lab.Name = "sendOnChangeVal_lab";
            this.sendOnChangeVal_lab.Size = new System.Drawing.Size(48, 13);
            this.sendOnChangeVal_lab.TabIndex = 14;
            this.sendOnChangeVal_lab.Text = "Disabled";
            // 
            // freq_textbox
            // 
            this.freq_textbox.Location = new System.Drawing.Point(256, 128);
            this.freq_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.freq_textbox.Name = "freq_textbox";
            this.freq_textbox.ReadOnly = true;
            this.freq_textbox.Size = new System.Drawing.Size(56, 20);
            this.freq_textbox.TabIndex = 9;
            this.freq_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vol_textbox
            // 
            this.Vol_textbox.Location = new System.Drawing.Point(256, 89);
            this.Vol_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Vol_textbox.Name = "Vol_textbox";
            this.Vol_textbox.ReadOnly = true;
            this.Vol_textbox.Size = new System.Drawing.Size(56, 20);
            this.Vol_textbox.TabIndex = 8;
            this.Vol_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freqencyInfo_label
            // 
            this.freqencyInfo_label.AutoSize = true;
            this.freqencyInfo_label.Location = new System.Drawing.Point(77, 115);
            this.freqencyInfo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.freqencyInfo_label.Name = "freqencyInfo_label";
            this.freqencyInfo_label.Size = new System.Drawing.Size(57, 13);
            this.freqencyInfo_label.TabIndex = 7;
            this.freqencyInfo_label.Text = "Frequency";
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(86, 76);
            this.volume_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(42, 13);
            this.volume_label.TabIndex = 6;
            this.volume_label.Text = "Volume";
            // 
            // freq_scrollbar
            // 
            this.freq_scrollbar.LargeChange = 1;
            this.freq_scrollbar.Location = new System.Drawing.Point(15, 129);
            this.freq_scrollbar.Maximum = 1080;
            this.freq_scrollbar.Minimum = 760;
            this.freq_scrollbar.Name = "freq_scrollbar";
            this.freq_scrollbar.Size = new System.Drawing.Size(214, 26);
            this.freq_scrollbar.TabIndex = 1;
            this.freq_scrollbar.Value = 892;
            this.freq_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.freq_scrollbar_Scroll);
            // 
            // volume_scrollbar
            // 
            this.volume_scrollbar.LargeChange = 1;
            this.volume_scrollbar.Location = new System.Drawing.Point(17, 90);
            this.volume_scrollbar.Maximum = 15;
            this.volume_scrollbar.Name = "volume_scrollbar";
            this.volume_scrollbar.Size = new System.Drawing.Size(212, 26);
            this.volume_scrollbar.TabIndex = 0;
            this.volume_scrollbar.Value = 7;
            this.volume_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_scrollbar_Scroll);
            // 
            // TxRxEvents_lab
            // 
            this.TxRxEvents_lab.AutoSize = true;
            this.TxRxEvents_lab.Location = new System.Drawing.Point(454, 28);
            this.TxRxEvents_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxRxEvents_lab.Name = "TxRxEvents_lab";
            this.TxRxEvents_lab.Size = new System.Drawing.Size(151, 13);
            this.TxRxEvents_lab.TabIndex = 4;
            this.TxRxEvents_lab.Text = "COM events and UART TxRx ";
            // 
            // RDSmsg_lab
            // 
            this.RDSmsg_lab.AutoSize = true;
            this.RDSmsg_lab.Location = new System.Drawing.Point(778, 28);
            this.RDSmsg_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RDSmsg_lab.Name = "RDSmsg_lab";
            this.RDSmsg_lab.Size = new System.Drawing.Size(80, 13);
            this.RDSmsg_lab.TabIndex = 5;
            this.RDSmsg_lab.Text = "RDS messages";
            // 
            // COMUARTmsg_richtextbox
            // 
            this.COMUARTmsg_richtextbox.Location = new System.Drawing.Point(402, 59);
            this.COMUARTmsg_richtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.COMUARTmsg_richtextbox.Name = "COMUARTmsg_richtextbox";
            this.COMUARTmsg_richtextbox.Size = new System.Drawing.Size(307, 582);
            this.COMUARTmsg_richtextbox.TabIndex = 6;
            this.COMUARTmsg_richtextbox.Text = "";
            // 
            // RDSmsg_richtextbox
            // 
            this.RDSmsg_richtextbox.Location = new System.Drawing.Point(731, 59);
            this.RDSmsg_richtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.RDSmsg_richtextbox.Name = "RDSmsg_richtextbox";
            this.RDSmsg_richtextbox.Size = new System.Drawing.Size(330, 582);
            this.RDSmsg_richtextbox.TabIndex = 7;
            this.RDSmsg_richtextbox.Text = "";
            // 
            // read_groupbox
            // 
            this.read_groupbox.Controls.Add(this.OFF_lab);
            this.read_groupbox.Controls.Add(this.ON_lab);
            this.read_groupbox.Controls.Add(this.PeriodRead_lab);
            this.read_groupbox.Controls.Add(this.chst_val_lab);
            this.read_groupbox.Controls.Add(this.stro_val_lab);
            this.read_groupbox.Controls.Add(this.rdsr_val_lab);
            this.read_groupbox.Controls.Add(this.rdss_val_lab);
            this.read_groupbox.Controls.Add(this.rssi_val_lab);
            this.read_groupbox.Controls.Add(this.chs_scrollbar);
            this.read_groupbox.Controls.Add(this.chst_button);
            this.read_groupbox.Controls.Add(this.str_scrollbar);
            this.read_groupbox.Controls.Add(this.stro_button);
            this.read_groupbox.Controls.Add(this.rdsr_scrollbar);
            this.read_groupbox.Controls.Add(this.rdsr_button);
            this.read_groupbox.Controls.Add(this.rdss_button);
            this.read_groupbox.Controls.Add(this.rds_scrollbar);
            this.read_groupbox.Controls.Add(this.rssi_scrollbar);
            this.read_groupbox.Controls.Add(this.rssi_button);
            this.read_groupbox.Location = new System.Drawing.Point(25, 470);
            this.read_groupbox.Margin = new System.Windows.Forms.Padding(2);
            this.read_groupbox.Name = "read_groupbox";
            this.read_groupbox.Padding = new System.Windows.Forms.Padding(2);
            this.read_groupbox.Size = new System.Drawing.Size(343, 171);
            this.read_groupbox.TabIndex = 24;
            this.read_groupbox.TabStop = false;
            this.read_groupbox.Text = "Read control";
            // 
            // OFF_lab
            // 
            this.OFF_lab.AutoSize = true;
            this.OFF_lab.Location = new System.Drawing.Point(290, 136);
            this.OFF_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OFF_lab.Name = "OFF_lab";
            this.OFF_lab.Size = new System.Drawing.Size(27, 13);
            this.OFF_lab.TabIndex = 40;
            this.OFF_lab.Text = "OFF";
            // 
            // ON_lab
            // 
            this.ON_lab.AutoSize = true;
            this.ON_lab.Location = new System.Drawing.Point(291, 67);
            this.ON_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ON_lab.Name = "ON_lab";
            this.ON_lab.Size = new System.Drawing.Size(23, 13);
            this.ON_lab.TabIndex = 39;
            this.ON_lab.Text = "ON";
            // 
            // PeriodRead_lab
            // 
            this.PeriodRead_lab.AutoSize = true;
            this.PeriodRead_lab.Location = new System.Drawing.Point(290, 100);
            this.PeriodRead_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PeriodRead_lab.Name = "PeriodRead_lab";
            this.PeriodRead_lab.Size = new System.Drawing.Size(45, 13);
            this.PeriodRead_lab.TabIndex = 38;
            this.PeriodRead_lab.Text = "Periodic";
            // 
            // chst_val_lab
            // 
            this.chst_val_lab.AutoSize = true;
            this.chst_val_lab.Location = new System.Drawing.Point(251, 136);
            this.chst_val_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chst_val_lab.Name = "chst_val_lab";
            this.chst_val_lab.Size = new System.Drawing.Size(12, 13);
            this.chst_val_lab.TabIndex = 37;
            this.chst_val_lab.Text = "x";
            // 
            // stro_val_lab
            // 
            this.stro_val_lab.AutoSize = true;
            this.stro_val_lab.Location = new System.Drawing.Point(194, 136);
            this.stro_val_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stro_val_lab.Name = "stro_val_lab";
            this.stro_val_lab.Size = new System.Drawing.Size(12, 13);
            this.stro_val_lab.TabIndex = 36;
            this.stro_val_lab.Text = "x";
            // 
            // rdsr_val_lab
            // 
            this.rdsr_val_lab.AutoSize = true;
            this.rdsr_val_lab.Location = new System.Drawing.Point(139, 136);
            this.rdsr_val_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rdsr_val_lab.Name = "rdsr_val_lab";
            this.rdsr_val_lab.Size = new System.Drawing.Size(12, 13);
            this.rdsr_val_lab.TabIndex = 35;
            this.rdsr_val_lab.Text = "x";
            // 
            // rdss_val_lab
            // 
            this.rdss_val_lab.AutoSize = true;
            this.rdss_val_lab.Location = new System.Drawing.Point(84, 136);
            this.rdss_val_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rdss_val_lab.Name = "rdss_val_lab";
            this.rdss_val_lab.Size = new System.Drawing.Size(12, 13);
            this.rdss_val_lab.TabIndex = 34;
            this.rdss_val_lab.Text = "x";
            // 
            // rssi_val_lab
            // 
            this.rssi_val_lab.AutoSize = true;
            this.rssi_val_lab.Location = new System.Drawing.Point(25, 136);
            this.rssi_val_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rssi_val_lab.Name = "rssi_val_lab";
            this.rssi_val_lab.Size = new System.Drawing.Size(17, 13);
            this.rssi_val_lab.TabIndex = 19;
            this.rssi_val_lab.Text = "xx";
            // 
            // chs_scrollbar
            // 
            this.chs_scrollbar.LargeChange = 1;
            this.chs_scrollbar.Location = new System.Drawing.Point(229, 64);
            this.chs_scrollbar.Maximum = 1;
            this.chs_scrollbar.Name = "chs_scrollbar";
            this.chs_scrollbar.Size = new System.Drawing.Size(54, 72);
            this.chs_scrollbar.TabIndex = 33;
            // 
            // chst_button
            // 
            this.chst_button.Location = new System.Drawing.Point(229, 42);
            this.chst_button.Margin = new System.Windows.Forms.Padding(2);
            this.chst_button.Name = "chst_button";
            this.chst_button.Size = new System.Drawing.Size(56, 21);
            this.chst_button.TabIndex = 32;
            this.chst_button.Text = "CHST";
            this.chst_button.UseVisualStyleBackColor = true;
            this.chst_button.Click += new System.EventHandler(this.chst_button_Click);
            // 
            // str_scrollbar
            // 
            this.str_scrollbar.LargeChange = 1;
            this.str_scrollbar.Location = new System.Drawing.Point(173, 64);
            this.str_scrollbar.Maximum = 1;
            this.str_scrollbar.Name = "str_scrollbar";
            this.str_scrollbar.Size = new System.Drawing.Size(54, 72);
            this.str_scrollbar.TabIndex = 31;
            // 
            // stro_button
            // 
            this.stro_button.Location = new System.Drawing.Point(173, 42);
            this.stro_button.Margin = new System.Windows.Forms.Padding(2);
            this.stro_button.Name = "stro_button";
            this.stro_button.Size = new System.Drawing.Size(56, 21);
            this.stro_button.TabIndex = 30;
            this.stro_button.Text = "STRO";
            this.stro_button.UseVisualStyleBackColor = true;
            this.stro_button.Click += new System.EventHandler(this.stro_button_Click);
            // 
            // rdsr_scrollbar
            // 
            this.rdsr_scrollbar.LargeChange = 1;
            this.rdsr_scrollbar.Location = new System.Drawing.Point(118, 64);
            this.rdsr_scrollbar.Maximum = 1;
            this.rdsr_scrollbar.Name = "rdsr_scrollbar";
            this.rdsr_scrollbar.Size = new System.Drawing.Size(54, 72);
            this.rdsr_scrollbar.TabIndex = 29;
            // 
            // rdsr_button
            // 
            this.rdsr_button.Location = new System.Drawing.Point(117, 42);
            this.rdsr_button.Margin = new System.Windows.Forms.Padding(2);
            this.rdsr_button.Name = "rdsr_button";
            this.rdsr_button.Size = new System.Drawing.Size(56, 21);
            this.rdsr_button.TabIndex = 28;
            this.rdsr_button.Text = "RDSR";
            this.rdsr_button.UseVisualStyleBackColor = true;
            this.rdsr_button.Click += new System.EventHandler(this.rdsr_button_Click);
            // 
            // rdss_button
            // 
            this.rdss_button.Location = new System.Drawing.Point(61, 42);
            this.rdss_button.Margin = new System.Windows.Forms.Padding(2);
            this.rdss_button.Name = "rdss_button";
            this.rdss_button.Size = new System.Drawing.Size(56, 21);
            this.rdss_button.TabIndex = 27;
            this.rdss_button.Text = "RDSS";
            this.rdss_button.UseVisualStyleBackColor = true;
            this.rdss_button.Click += new System.EventHandler(this.rdss_button_Click);
            // 
            // rds_scrollbar
            // 
            this.rds_scrollbar.LargeChange = 1;
            this.rds_scrollbar.Location = new System.Drawing.Point(62, 64);
            this.rds_scrollbar.Maximum = 1;
            this.rds_scrollbar.Name = "rds_scrollbar";
            this.rds_scrollbar.Size = new System.Drawing.Size(54, 72);
            this.rds_scrollbar.TabIndex = 21;
            // 
            // rssi_scrollbar
            // 
            this.rssi_scrollbar.LargeChange = 1;
            this.rssi_scrollbar.Location = new System.Drawing.Point(6, 64);
            this.rssi_scrollbar.Maximum = 1;
            this.rssi_scrollbar.Name = "rssi_scrollbar";
            this.rssi_scrollbar.Size = new System.Drawing.Size(54, 72);
            this.rssi_scrollbar.TabIndex = 20;
            // 
            // rssi_button
            // 
            this.rssi_button.Location = new System.Drawing.Point(5, 42);
            this.rssi_button.Margin = new System.Windows.Forms.Padding(2);
            this.rssi_button.Name = "rssi_button";
            this.rssi_button.Size = new System.Drawing.Size(56, 21);
            this.rssi_button.TabIndex = 19;
            this.rssi_button.Text = "RSSI";
            this.rssi_button.UseVisualStyleBackColor = true;
            this.rssi_button.Click += new System.EventHandler(this.rssi_button_Click);
            // 
            // getBLKA_button
            // 
            this.getBLKA_button.Location = new System.Drawing.Point(1076, 54);
            this.getBLKA_button.Margin = new System.Windows.Forms.Padding(2);
            this.getBLKA_button.Name = "getBLKA_button";
            this.getBLKA_button.Size = new System.Drawing.Size(106, 28);
            this.getBLKA_button.TabIndex = 17;
            this.getBLKA_button.Text = "Get Block A";
            this.getBLKA_button.UseVisualStyleBackColor = true;
            // 
            // getBLKB_button
            // 
            this.getBLKB_button.Location = new System.Drawing.Point(1076, 88);
            this.getBLKB_button.Margin = new System.Windows.Forms.Padding(2);
            this.getBLKB_button.Name = "getBLKB_button";
            this.getBLKB_button.Size = new System.Drawing.Size(106, 28);
            this.getBLKB_button.TabIndex = 25;
            this.getBLKB_button.Text = "Get Block B";
            this.getBLKB_button.UseVisualStyleBackColor = true;
            // 
            // getBLKC_button
            // 
            this.getBLKC_button.Location = new System.Drawing.Point(1076, 123);
            this.getBLKC_button.Margin = new System.Windows.Forms.Padding(2);
            this.getBLKC_button.Name = "getBLKC_button";
            this.getBLKC_button.Size = new System.Drawing.Size(106, 28);
            this.getBLKC_button.TabIndex = 26;
            this.getBLKC_button.Text = "Get Block C";
            this.getBLKC_button.UseVisualStyleBackColor = true;
            this.getBLKC_button.Click += new System.EventHandler(this.getBLKC_button_Click);
            // 
            // getBLKD_button
            // 
            this.getBLKD_button.Location = new System.Drawing.Point(1076, 157);
            this.getBLKD_button.Margin = new System.Windows.Forms.Padding(2);
            this.getBLKD_button.Name = "getBLKD_button";
            this.getBLKD_button.Size = new System.Drawing.Size(106, 28);
            this.getBLKD_button.TabIndex = 27;
            this.getBLKD_button.Text = "Get Block D";
            this.getBLKD_button.UseVisualStyleBackColor = true;
            this.getBLKD_button.Click += new System.EventHandler(this.getBLKD_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 680);
            this.Controls.Add(this.getBLKD_button);
            this.Controls.Add(this.getBLKC_button);
            this.Controls.Add(this.getBLKB_button);
            this.Controls.Add(this.getBLKA_button);
            this.Controls.Add(this.read_groupbox);
            this.Controls.Add(this.RDSmsg_richtextbox);
            this.Controls.Add(this.COMUARTmsg_richtextbox);
            this.Controls.Add(this.RDSmsg_lab);
            this.Controls.Add(this.TxRxEvents_lab);
            this.Controls.Add(this.RDA_groupbox);
            this.Controls.Add(this.COM_groupbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "RDA5807M Control/View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.COM_groupbox.ResumeLayout(false);
            this.COM_groupbox.PerformLayout();
            this.RDA_groupbox.ResumeLayout(false);
            this.RDA_groupbox.PerformLayout();
            this.read_groupbox.ResumeLayout(false);
            this.read_groupbox.PerformLayout();
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
        private System.Windows.Forms.Button send_btn;
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
        private System.Windows.Forms.Button getBLKA_button;
        private System.Windows.Forms.Button getBLKB_button;
        private System.Windows.Forms.Button getBLKC_button;
        private System.Windows.Forms.Button getBLKD_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button init_button;
        private System.Windows.Forms.Button mute_button;
        private System.Windows.Forms.Label OFF_lab;
        private System.Windows.Forms.Label ON_lab;
        private System.Windows.Forms.Label PeriodRead_lab;
        private System.Windows.Forms.Label chst_val_lab;
        private System.Windows.Forms.Label stro_val_lab;
        private System.Windows.Forms.Label rdsr_val_lab;
        private System.Windows.Forms.Label rdss_val_lab;
        private System.Windows.Forms.Label rssi_val_lab;
        private System.Windows.Forms.VScrollBar chs_scrollbar;
        private System.Windows.Forms.Button chst_button;
        private System.Windows.Forms.VScrollBar str_scrollbar;
        private System.Windows.Forms.Button stro_button;
        private System.Windows.Forms.VScrollBar rdsr_scrollbar;
        private System.Windows.Forms.Button rdsr_button;
        private System.Windows.Forms.Button rdss_button;
        private System.Windows.Forms.VScrollBar rds_scrollbar;
        private System.Windows.Forms.VScrollBar rssi_scrollbar;
        private System.Windows.Forms.Button rssi_button;
    }
}

