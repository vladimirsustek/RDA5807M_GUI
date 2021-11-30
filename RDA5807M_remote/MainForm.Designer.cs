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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar5 = new System.Windows.Forms.VScrollBar();
            this.button5 = new System.Windows.Forms.Button();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.button4 = new System.Windows.Forms.Button();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
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
            this.RDA_groupbox.Location = new System.Drawing.Point(22, 247);
            this.RDA_groupbox.Name = "RDA_groupbox";
            this.RDA_groupbox.Size = new System.Drawing.Size(406, 298);
            this.RDA_groupbox.TabIndex = 1;
            this.RDA_groupbox.TabStop = false;
            this.RDA_groupbox.Text = "RDA5807 control";
            // 
            // mute_button
            // 
            this.mute_button.Location = new System.Drawing.Point(34, 252);
            this.mute_button.Name = "mute_button";
            this.mute_button.Size = new System.Drawing.Size(144, 26);
            this.mute_button.TabIndex = 18;
            this.mute_button.Text = "Mute";
            this.mute_button.UseVisualStyleBackColor = true;
            this.mute_button.Click += new System.EventHandler(this.mute_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(220, 48);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(144, 26);
            this.reset_button.TabIndex = 17;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // init_button
            // 
            this.init_button.Location = new System.Drawing.Point(34, 48);
            this.init_button.Name = "init_button";
            this.init_button.Size = new System.Drawing.Size(144, 26);
            this.init_button.TabIndex = 16;
            this.init_button.Text = "Initialize";
            this.init_button.UseVisualStyleBackColor = true;
            this.init_button.Click += new System.EventHandler(this.init_button_Click);
            // 
            // sendOnChange_lab
            // 
            this.sendOnChange_lab.AutoSize = true;
            this.sendOnChange_lab.Location = new System.Drawing.Point(273, 205);
            this.sendOnChange_lab.Name = "sendOnChange_lab";
            this.sendOnChange_lab.Size = new System.Drawing.Size(112, 17);
            this.sendOnChange_lab.TabIndex = 13;
            this.sendOnChange_lab.Text = "Send on change";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(34, 205);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(144, 26);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "Send (Vol, Freq)";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // freqVal_lab
            // 
            this.freqVal_lab.AutoSize = true;
            this.freqVal_lab.Location = new System.Drawing.Point(324, 142);
            this.freqVal_lab.Name = "freqVal_lab";
            this.freqVal_lab.Size = new System.Drawing.Size(40, 17);
            this.freqVal_lab.TabIndex = 11;
            this.freqVal_lab.Text = " MHz";
            // 
            // SendOnChange_scrbar
            // 
            this.SendOnChange_scrbar.LargeChange = 1;
            this.SendOnChange_scrbar.Location = new System.Drawing.Point(276, 222);
            this.SendOnChange_scrbar.Maximum = 1;
            this.SendOnChange_scrbar.Name = "SendOnChange_scrbar";
            this.SendOnChange_scrbar.Size = new System.Drawing.Size(109, 26);
            this.SendOnChange_scrbar.TabIndex = 12;
            this.SendOnChange_scrbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SendOnChange_scrbar_Scroll);
            // 
            // volumeVal_lab
            // 
            this.volumeVal_lab.AutoSize = true;
            this.volumeVal_lab.Location = new System.Drawing.Point(320, 94);
            this.volumeVal_lab.Name = "volumeVal_lab";
            this.volumeVal_lab.Size = new System.Drawing.Size(50, 17);
            this.volumeVal_lab.TabIndex = 10;
            this.volumeVal_lab.Text = " val/15";
            // 
            // sendOnChangeVal_lab
            // 
            this.sendOnChangeVal_lab.AutoSize = true;
            this.sendOnChangeVal_lab.Location = new System.Drawing.Point(296, 252);
            this.sendOnChangeVal_lab.Name = "sendOnChangeVal_lab";
            this.sendOnChangeVal_lab.Size = new System.Drawing.Size(63, 17);
            this.sendOnChangeVal_lab.TabIndex = 14;
            this.sendOnChangeVal_lab.Text = "Disabled";
            // 
            // freq_textbox
            // 
            this.freq_textbox.Location = new System.Drawing.Point(311, 159);
            this.freq_textbox.Name = "freq_textbox";
            this.freq_textbox.ReadOnly = true;
            this.freq_textbox.Size = new System.Drawing.Size(74, 22);
            this.freq_textbox.TabIndex = 9;
            this.freq_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vol_textbox
            // 
            this.Vol_textbox.Location = new System.Drawing.Point(311, 111);
            this.Vol_textbox.Name = "Vol_textbox";
            this.Vol_textbox.ReadOnly = true;
            this.Vol_textbox.Size = new System.Drawing.Size(74, 22);
            this.Vol_textbox.TabIndex = 8;
            this.Vol_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freqencyInfo_label
            // 
            this.freqencyInfo_label.AutoSize = true;
            this.freqencyInfo_label.Location = new System.Drawing.Point(103, 142);
            this.freqencyInfo_label.Name = "freqencyInfo_label";
            this.freqencyInfo_label.Size = new System.Drawing.Size(75, 17);
            this.freqencyInfo_label.TabIndex = 7;
            this.freqencyInfo_label.Text = "Frequency";
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(114, 94);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(55, 17);
            this.volume_label.TabIndex = 6;
            this.volume_label.Text = "Volume";
            // 
            // freq_scrollbar
            // 
            this.freq_scrollbar.LargeChange = 1;
            this.freq_scrollbar.Location = new System.Drawing.Point(20, 159);
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
            this.volume_scrollbar.Location = new System.Drawing.Point(23, 111);
            this.volume_scrollbar.Maximum = 15;
            this.volume_scrollbar.Name = "volume_scrollbar";
            this.volume_scrollbar.Size = new System.Drawing.Size(255, 26);
            this.volume_scrollbar.TabIndex = 0;
            this.volume_scrollbar.Value = 7;
            this.volume_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_scrollbar_Scroll);
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
            this.RDSmsg_lab.Location = new System.Drawing.Point(958, 35);
            this.RDSmsg_lab.Name = "RDSmsg_lab";
            this.RDSmsg_lab.Size = new System.Drawing.Size(105, 17);
            this.RDSmsg_lab.TabIndex = 5;
            this.RDSmsg_lab.Text = "RDS messages";
            // 
            // COMUARTmsg_richtextbox
            // 
            this.COMUARTmsg_richtextbox.Location = new System.Drawing.Point(469, 67);
            this.COMUARTmsg_richtextbox.Name = "COMUARTmsg_richtextbox";
            this.COMUARTmsg_richtextbox.Size = new System.Drawing.Size(353, 707);
            this.COMUARTmsg_richtextbox.TabIndex = 6;
            this.COMUARTmsg_richtextbox.Text = "";
            // 
            // RDSmsg_richtextbox
            // 
            this.RDSmsg_richtextbox.Location = new System.Drawing.Point(828, 67);
            this.RDSmsg_richtextbox.Name = "RDSmsg_richtextbox";
            this.RDSmsg_richtextbox.Size = new System.Drawing.Size(365, 707);
            this.RDSmsg_richtextbox.TabIndex = 7;
            this.RDSmsg_richtextbox.Text = "";
            // 
            // read_groupbox
            // 
            this.read_groupbox.Controls.Add(this.label8);
            this.read_groupbox.Controls.Add(this.label7);
            this.read_groupbox.Controls.Add(this.label6);
            this.read_groupbox.Controls.Add(this.label5);
            this.read_groupbox.Controls.Add(this.label4);
            this.read_groupbox.Controls.Add(this.label3);
            this.read_groupbox.Controls.Add(this.label2);
            this.read_groupbox.Controls.Add(this.label1);
            this.read_groupbox.Controls.Add(this.vScrollBar5);
            this.read_groupbox.Controls.Add(this.button5);
            this.read_groupbox.Controls.Add(this.vScrollBar4);
            this.read_groupbox.Controls.Add(this.button4);
            this.read_groupbox.Controls.Add(this.vScrollBar3);
            this.read_groupbox.Controls.Add(this.button3);
            this.read_groupbox.Controls.Add(this.button2);
            this.read_groupbox.Controls.Add(this.vScrollBar2);
            this.read_groupbox.Controls.Add(this.vScrollBar1);
            this.read_groupbox.Controls.Add(this.button1);
            this.read_groupbox.Location = new System.Drawing.Point(33, 578);
            this.read_groupbox.Name = "read_groupbox";
            this.read_groupbox.Size = new System.Drawing.Size(406, 196);
            this.read_groupbox.TabIndex = 24;
            this.read_groupbox.TabStop = false;
            this.read_groupbox.Text = "Read control";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "ON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Periodic reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "xx";
            // 
            // vScrollBar5
            // 
            this.vScrollBar5.Location = new System.Drawing.Point(257, 79);
            this.vScrollBar5.Name = "vScrollBar5";
            this.vScrollBar5.Size = new System.Drawing.Size(21, 89);
            this.vScrollBar5.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(240, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 26);
            this.button5.TabIndex = 32;
            this.button5.Text = "CHST";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(201, 79);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(21, 89);
            this.vScrollBar4.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 26);
            this.button4.TabIndex = 30;
            this.button4.Text = "STRO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(143, 79);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(21, 89);
            this.vScrollBar3.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 26);
            this.button3.TabIndex = 28;
            this.button3.Text = "RDSR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 26);
            this.button2.TabIndex = 27;
            this.button2.Text = "RDSS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(85, 79);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 89);
            this.vScrollBar2.TabIndex = 21;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(28, 79);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 89);
            this.vScrollBar1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "RSSI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // getBLKA_button
            // 
            this.getBLKA_button.Location = new System.Drawing.Point(1312, 67);
            this.getBLKA_button.Name = "getBLKA_button";
            this.getBLKA_button.Size = new System.Drawing.Size(142, 34);
            this.getBLKA_button.TabIndex = 17;
            this.getBLKA_button.Text = "Get Block A";
            this.getBLKA_button.UseVisualStyleBackColor = true;
            // 
            // getBLKB_button
            // 
            this.getBLKB_button.Location = new System.Drawing.Point(1312, 108);
            this.getBLKB_button.Name = "getBLKB_button";
            this.getBLKB_button.Size = new System.Drawing.Size(142, 34);
            this.getBLKB_button.TabIndex = 25;
            this.getBLKB_button.Text = "Get Block B";
            this.getBLKB_button.UseVisualStyleBackColor = true;
            // 
            // getBLKC_button
            // 
            this.getBLKC_button.Location = new System.Drawing.Point(1312, 151);
            this.getBLKC_button.Name = "getBLKC_button";
            this.getBLKC_button.Size = new System.Drawing.Size(142, 34);
            this.getBLKC_button.TabIndex = 26;
            this.getBLKC_button.Text = "Get Block C";
            this.getBLKC_button.UseVisualStyleBackColor = true;
            this.getBLKC_button.Click += new System.EventHandler(this.getBLKC_button_Click);
            // 
            // getBLKD_button
            // 
            this.getBLKD_button.Location = new System.Drawing.Point(1312, 193);
            this.getBLKD_button.Name = "getBLKD_button";
            this.getBLKD_button.Size = new System.Drawing.Size(142, 34);
            this.getBLKD_button.TabIndex = 27;
            this.getBLKD_button.Text = "Get Block D";
            this.getBLKD_button.UseVisualStyleBackColor = true;
            this.getBLKD_button.Click += new System.EventHandler(this.getBLKD_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 837);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
    }
}

