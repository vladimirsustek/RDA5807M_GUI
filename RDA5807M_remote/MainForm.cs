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
        private COMDevice Device = new COMDevice();
        private RDA5807M Radio = new RDA5807M();

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.COM_combobox.Items.AddRange(ports);
        }

        private void VOlumeChanged()
        {
            float freq = Int32.Parse(freq_textbox.Text);
            int volume = Int32.Parse(Vol_textbox.Text);
            int freqParsed = (int)(freq * 10);

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
                if (!Device.isConnected())
                {
                    Device.Connect(this.COM_combobox.Text);

                    if (Device.isConnected())
                    {
                        this.COMState_label.Text = "Connected";
                        this.printlineTimestamped(COMUARTmsg_richtextbox, "Connected");
                    }
                }
                else
                {
                    Device.Close();
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

        private void send_btn_Click(object sender, EventArgs e)
        {
            int volume = 0;
            float freq = 0;
            try
            {
                freq = float.Parse(freq_textbox.Text);
                volume = Int32.Parse(Vol_textbox.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.Message);
            }

            int freqParsed = (int)(freq *10);
            Console.WriteLine(freq.ToString());
            Console.WriteLine(volume.ToString());

            Console.WriteLine(Radio.cmdSetVolume(volume));
            Console.WriteLine(Radio.cmdSetChannel(freqParsed));
        }

        private void volume_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                Vol_textbox.Text = volume_scrollbar.Value.ToString();
            }

        }

        private void freq_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                float freq = ((float)(freq_scrollbar.Value)) / 10;
                freq_textbox.Text = freq.ToString();
            }
        }
    }
}
