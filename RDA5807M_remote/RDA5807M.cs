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
        private const string cmd_init = "DO_INIT";

        private const string cmd_rset = "DO_RSET";

        private const string cmd_mute = "ST_MUTE_";

        private const string cmd_freq = "ST_FREQ_";

        private const string cmd_volm = "ST_VOLM_";

        private const string cmd_rssi = "GT_RSSI";

        private const string cmd_blka = "GT_BLKA";

        private const string cmd_blkb = "GT_BLKB";

        private const string cmd_blkc = "GT_BLKC";

        private const string cmd_blkd = "GT_BLKD";

        private const int TWO_LINES_RESPONSE = 2;


        public const char BLKA = 'A';
        public const char BLKB = 'B';
        public const char BLKC = 'C';
        public const char BLKD = 'D';

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
        public string cmdRDA5807MResetProcess()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_rset, TWO_LINES_RESPONSE);
                result = "RX: " + result.PadRight(0, ' ');

            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
        public string cmdRDA5807MSetMute(int vol)
        {
            string result;
            string strMute = vol.ToString();

            strMute = cmd_mute + strMute;

            try
            {
                result = this.WriteAndReadLine(strMute, TWO_LINES_RESPONSE);
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

        public string cmdRDA5807MGetBLK(char block)
        {
            string result;
            string cmd;

            try
            {
                switch (block) {
                    case 'A':
                        {
                            cmd = cmd_blka;
                        }
                        break;
                    case 'B':
                        {
                            cmd = cmd_blkb;
                        }
                        break;
                    case 'C':
                        {
                            cmd = cmd_blkc;
                        }
                        break;
                    case 'D':
                        {
                            cmd = cmd_blkd;
                        }
                        break;
                    default:
                        {
                            cmd = "";
                        }
                        break;
                }
                result = this.WriteAndReadLine(cmd, TWO_LINES_RESPONSE);
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
