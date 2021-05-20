using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace RDA5807M_remote
{
    public class COMDevice
    {
        public string PortName = "None";
        public int Baudrate = 57600;
        public string strParity = "None";
        public string strStopBits = "One";
        public int RxTimeout = 100;
        public int TxTimeout = 100;

        private SerialPort Serial = new SerialPort("COM1");

        public COMDevice()
        {
            Serial.DataBits = 8;

            Serial.PortName = PortName;
            Serial.BaudRate = Baudrate;
            Serial.Parity = this.parseParity(strParity);
            Serial.StopBits = this.parseStopBits(strStopBits);
            Serial.ReadTimeout = RxTimeout;
            Serial.WriteTimeout = TxTimeout;
        }

        public bool isConnected()
        {
            return this.Serial.IsOpen;
        }

        private Parity parseParity(string strParity)
        {
            Parity nativeParity;
            switch(strParity)
            {
                case "None":
                    {
                        nativeParity = Parity.None;
                    }
                    break;
                case "Odd":
                    {
                        nativeParity = Parity.Odd;
                    }
                    break;
                case "Even":
                    {
                        nativeParity = Parity.Even;
                    }
                    break;
                default:
                    {
                        nativeParity = Parity.None;
                    }
                    break;
            }

            return nativeParity;
        }
        private StopBits parseStopBits(string strStopBits)
        {
            StopBits nativeStopBits = StopBits.None;
            switch (strStopBits)
            {
                case "None":
                    {
                        nativeStopBits = StopBits.None;
                    }
                    break;
                case "One":
                    {
                        nativeStopBits = StopBits.One;
                    }
                    break;
                case "Two":
                    {
                        nativeStopBits = StopBits.Two;
                    }
                    break;
                case "OnePointFive":
                    {
                        nativeStopBits = StopBits.OnePointFive;
                    }
                    break;
                default:
                    {
                        nativeStopBits = StopBits.None;
                    }
                    break;
            }

            return nativeStopBits;
        }

        public int Connect(String COMPortName = "Optional")
        {
            int result = 0;

            if (COMPortName == "Optional")
            {
                this.Serial.PortName = PortName;
            }
            else
            {
                this.Serial.PortName = COMPortName;
            }
            try
            {
                if (!this.Serial.IsOpen)
                {
                    this.Serial.Open();
                }
                else
                {
                    result = 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            return result;
        }
        public int Close()
        {
            int result = 0;

            try
            {
                if (this.Serial.IsOpen)
                {
                    this.Serial.Close();
                }
                else
                {
                    result = 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            return result;
        }
        public int WriteLine(string line)
        {
            int result = 0;
            if (this.Serial.IsOpen)
            {
                try
                {
                    this.Serial.WriteLine(line);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error of message = {0}", e.Message);
                    result = 2;
                }

            }
            else
            {
                result = 1;
            }
            return result;
        }

        public string ReadLine()
        {
            string msg = "";
            if (this.Serial.IsOpen)
            {
                try
                {
                    msg = this.Serial.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error of message = {0}", e.Message);
                    msg = "Error";
                }

            }
            else
            {
                msg = "ClosedPort";
            }
            return msg;
        }

        public string WriteAndReadLine(string line)
        {
            string response;

            this.WriteLine(line);
            response = this.ReadLine();

            return response;
        }
    }
}
