using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RDA5807M_remote
{
    class RDA5807M : COMDevice
    {
        private const string cmd_init = "DO_INIT\n";

        private const string cmd_freq = "ST_FREQ_";

        private const string cmd_volm = "ST_VOLM_";

        private const string cmd_rssi = "GT_RSSI";

        private const int TWO_LINES_RESPONSE = 2;

        public string cmdRDA5807MInitProcess()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_init, TWO_LINES_RESPONSE);
                result = "RX: " + result;
                   
            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }

        public string cmdRDA5807MSetsFreq(int freq)
        {
            string result;
            string strFreq = freq.ToString().PadLeft(5, '0');

            strFreq = cmd_freq + strFreq;

            try
            {
                result = this.WriteAndReadLine(strFreq, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }

        public string cmdRDA5807MSetVolume(int vol)
        {
            string result;
            string strVolm = vol.ToString().PadLeft(2, '0');

            strVolm = cmd_volm + strVolm;

            try
            {
                result = this.WriteAndReadLine(strVolm, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public string cmdRDA5807MGetRSSI()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_rssi, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }
    }
}
