using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RDA5807M_remote
{
    class rtu_rda5807m : rtu_device
    {
        private const string cmd_init = "DO_INIT";

        private const string cmd_rset = "DO_RSET";

        private const string cmd_mute = "ST_MUTE_";

        private const string cmd_freq = "ST_FREQ_";

        private const string cmd_volm = "ST_VOLM_";

        private const string cmd_rssi = "GT_RSSI";

        private const string cmd_rdsr = "GT_RDSR";

        private const string cmd_rdss = "GT_RDSS";

        private const string cmd_stro = "GT_STRO";

        private const string cmd_chst = "GT_CHST";

        private const string cmd_blka = "GT_BLKA";

        private const string cmd_blkb = "GT_BLKB";

        private const string cmd_blkc = "GT_BLKC";

        private const string cmd_blkd = "GT_BLKD";

        private const int TWO_LINES_RESPONSE = 2;


        public const char BLKA = 'A';
        public const char BLKB = 'B';
        public const char BLKC = 'C';
        public const char BLKD = 'D';

        public int cmdRDA5807ReadRetHex(string rsp)
        {
            string[] splitted1 = rsp.Split('=');
            if (splitted1.Length < 2) return -1;

            string[] splitted2 = splitted1[1].Split('x');
            if (splitted2.Length < 2) return -1;

            int.TryParse(splitted2[1], System.Globalization.NumberStyles.HexNumber, null, out int val);
            return val;

        }
        public int cmdRDA5807ReadRetInt(string rsp)
        {
            string[] splitted1 = rsp.Split('=');
            if (splitted1.Length < 2) return -1;

            string[] splitted2 = splitted1[1].Split('x');
            if (splitted2.Length < 2) return -1;

            int.TryParse(splitted2[1], System.Globalization.NumberStyles.HexNumber, null, out int val);
            return val;
        }
        public string cmdRDA5807ReadRetString(string rsp)
        {
            string[] splitted1 = rsp.Split('=');
            if (splitted1.Length < 2) return "RetStrErr";

            string[] splitted2 = splitted1[1].Split('x');
            if (splitted2.Length < 2) return "RetStrErr";

            if (splitted2[1].Length != 4) return "RetStrErr";

            char[] arrfirst = { splitted2[1][0], splitted2[1][1] };
            char[] arrsecond = { splitted2[1][2], splitted2[1][3] };

            string strch1 = new string(arrfirst);
            string strch2 = new string(arrsecond);

            int.TryParse(strch1, System.Globalization.NumberStyles.HexNumber, null, out int intch1);
            int.TryParse(strch2, System.Globalization.NumberStyles.HexNumber, null, out int intch2);

            intch1 = (((intch1 >= 'a') && (intch1 <= 'z')) || 
                     ((intch1 >= 'A') && (intch1 <= 'Z')) || 
                     ((intch1 >= '0') && (intch1 <= '9')) ? intch1 : ' ');

            intch2 = (((intch2 >= 'a') && (intch2 <= 'z')) ||
                     ((intch2 >= 'A') && (intch2 <= 'Z')) ||
                     ((intch2 >= '0') && (intch2 <= '9')) ? intch2 : ' ');

            char[] arrconverted = {(char)(intch1), (char)(intch2)};
            string retstr = new string(arrconverted);
            return retstr;
        }
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

        public string cmdRDA5807MGetRDSS()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_rdss, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public string cmdRDA5807MGetRDSR()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_rdsr, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public string cmdRDA5807MGetSTRO()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_stro, TWO_LINES_RESPONSE);
                result = "RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public string cmdRDA5807MGetCHST()
        {
            string result;

            try
            {
                result = this.WriteAndReadLine(cmd_chst, TWO_LINES_RESPONSE);
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
