using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RDA5807M_remote
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DateTime localDate = DateTime.Now;
        private SerialPort COMInst = new SerialPort();

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.COM_combobox.Items.AddRange(ports);
            this.TxTimeout_textedit.Text = "100";
            this.RxTimeout_textedit.Text = "100";
            this.stopbits_combobox.SelectedIndex = 0;
            this.parity_combobox.SelectedIndex = 0;
        }

        private void COMConnectDisconnect_btn_Click(object sender, EventArgs e)
        {
            if (this.COM_combobox.Text != "")
            {
                if (COMInst.IsOpen == false)
                {
                    COMInst.PortName = this.COM_combobox.Text;
                    COMInst.BaudRate = Int32.Parse(this.baudrate_combobox.Text);
                    COMInst.DataBits = 8;

                    switch (this.parity_combobox.Text)
                    {
                        case "None":
                            {
                                COMInst.Parity = Parity.None;
                            }
                        break;
                        case "Odd":
                            {
                                COMInst.Parity = Parity.Odd;
                            }
                            break;
                        case "Even":
                            {
                                COMInst.Parity = Parity.Even;
                            }
                            break;
                    }
                    switch (this.stopbits_combobox.Text)
                    {
                        case "One":
                            {
                                COMInst.StopBits = StopBits.One;
                            }
                            break;
                        case "Two":
                            {
                                COMInst.StopBits = StopBits.Two;
                            }
                            break;
                    }

                    COMInst.ReadTimeout = Int32.Parse(this.RxTimeout_textedit.Text);
                    COMInst.ReadTimeout = Int32.Parse(this.TxTimeout_textedit.Text);
                    COMInst.Open();

                    if (this.COMInst.IsOpen == true)
                    {
                        this.COMState_label.Text = "Connected";
                        COMInst.WriteLine("LEDTG");
                        string response = COMInst.ReadLine();
                        this.COMUARTmsg_richtextbox.AppendText(localDate.ToString("HH:mm:ss.ff: ", System.Globalization.DateTimeFormatInfo.InvariantInfo));
                        this.COMUARTmsg_richtextbox.AppendText("LEDTG");
                        this.COMUARTmsg_richtextbox.AppendText("& RX = " + response);
                        this.COMUARTmsg_richtextbox.AppendText(Environment.NewLine);
                    }
                }
                else
                {
                    COMInst.Close();
                    if (this.COMInst.IsOpen == false)
                    {
                        this.COMState_label.Text = "Disconnected";
                    }
                }


            }

        }
    }
}
