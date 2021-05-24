using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA5807M_remote
{
    class RDA5807M : COMDevice
    {
        private string cmd_init = "RDA5807M_INIT_PRS";
        private string rsp_init = "RDA5807M_INITIALIZED";

        private string cmd_freq = "RDA5807M_FREQ_SET_";
        private string rsp_freq = "RDA5807M_FREQ_SET";

        private string cmd_volm = "RDA5807M_VOLM_SET_";
        private string rsp_volm = "RDA5807M_VOLM_SET";

        private string cmd_rssi = "RDA5807M_RSSI_GET";

        public string cmdRDA5807MInitProcess()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_init);
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
                result = this.WriteAndReadLine(strFreq);
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
                result = this.WriteAndReadLine(strVolm);
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
                result = this.WriteAndReadLine(cmd_rssi);
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
