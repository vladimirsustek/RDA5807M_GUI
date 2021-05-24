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
using System.Threading;

namespace RDA5807M_remote
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DateTime localDate = DateTime.Now;
        private RDA5807M Device = new RDA5807M();

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.COM_combobox.Items.AddRange(ports);
            this.baudrate_combobox.SelectedIndex = this.baudrate_combobox.FindStringExact("57600");
            this.stopbits_combobox.SelectedIndex = this.stopbits_combobox.FindStringExact("One");
            this.parity_combobox.SelectedIndex = this.parity_combobox.FindStringExact("None");
            this.Vol_textbox.Text = (this.volume_scrollbar.Value).ToString();
            this.freq_textbox.Text = ((float)this.freq_scrollbar.Value/10).ToString();
        }

        private void printlineTimestamped(RichTextBox textbox, string line)
        {
            this.localDate = DateTime.Now;
            textbox.AppendText(localDate.ToString("HH:mm:ss.ff: ", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            textbox.AppendText(line);
            textbox.AppendText(Environment.NewLine);
        }
        private void COMConnectDisconnect_btn_Click(object sender, EventArgs e)
        {
            if (this.COM_combobox.Text != "")
            {
                if (!this.Device.isConnected())
                {
                    this.Device.Connect(this.COM_combobox.Text);

                    if (this.Device.isConnected())
                    {
                        string rsp = this.Device.cmdRDA5807MInitProcess();
                        this.COMState_label.Text = "Connected";
                        this.printlineTimestamped(COMUARTmsg_richtextbox, rsp);
                    }
                }
                else
                {
                    this.Device.Close();
                    if (!Device.isConnected())
                    {
                        this.COMState_label.Text = "Disconnected";
                        this.printlineTimestamped(COMUARTmsg_richtextbox, "Disconnected");
                    }
                }
            }

        }

        private void COM_combobox_Clicked(object sender, EventArgs e)
        {

            for (int index = 0; index < this.COM_combobox.Items.Count; index++)
            {
                this.COM_combobox.Items.RemoveAt(index);
            }

            string[] ports = SerialPort.GetPortNames();
            this.COM_combobox.Items.AddRange(ports);
        }

        private void send_VolmFreq()
        {
            if (!this.Device.isConnected())
            {
                return;
            }
            int volume = 0;
            float freq = 0;
            string rsp;
            try
            {
                freq = float.Parse(freq_textbox.Text);
                volume = Int32.Parse(Vol_textbox.Text);

                freq *= 100;
                int intFreq = (int)freq;

                rsp = this.Device.cmdRDA5807MSetsFreq(intFreq);
                this.printlineTimestamped(COMUARTmsg_richtextbox, rsp);

                Thread.Sleep(250);

                rsp = this.Device.cmdRDA5807MSetVolume(volume);
                this.printlineTimestamped(COMUARTmsg_richtextbox, rsp);
            }
            catch (Exception exception)
            {
                this.printlineTimestamped(this.COMUARTmsg_richtextbox, exception.ToString());
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            this.send_VolmFreq();
        }

        private void volume_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                this.Vol_textbox.Text = (this.volume_scrollbar.Value).ToString();
                if (this.SendOnChange_scrbar.Value == 1)
                {
                    this.send_VolmFreq();
                }

            }

        }

        private void freq_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                this.freq_textbox.Text = ((float)this.freq_scrollbar.Value/10).ToString();
                if (this.SendOnChange_scrbar.Value == 1)
                {
                    this.send_VolmFreq();
                }
            }
        }

        private void getRSSI_button_Click(object sender, EventArgs e)
        {
            if (this.Device.isConnected())
            {
                try
                {
                    string rsp = this.Device.cmdRDA5807MGetRSSI();
                    this.printlineTimestamped(this.COMUARTmsg_richtextbox, rsp);
                }
                catch (Exception exception)
                {
                    this.printlineTimestamped(this.COMUARTmsg_richtextbox, exception.ToString());
                }
            }
        }

        private void SendOnChange_scrbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                if (this.SendOnChange_scrbar.Value == 1)
                {
                    this.sendOnChangeVal_lab.Text = "Enabled";
                }
                else
                {
                    this.sendOnChangeVal_lab.Text = "Disabled";
                }
            }
        }
    }
}
