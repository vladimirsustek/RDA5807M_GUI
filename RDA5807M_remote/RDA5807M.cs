using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDA5807M_remote
{
    class RDA5807M
    {
        public string cmdSetChannel(int freq)
        {
            string cmd = "FREQ" + freq.ToString().PadLeft(4, '0');
            return cmd;
        }
        public string cmdSetVolume(int volume)
        {
            string cmd = "VOLM" + volume.ToString().PadLeft(2, '0');
            return cmd;
        }

        public string cmdMute()
        {
            return "MUTE";
        }
        public string cmdUnMute()
        {
            return "UNMUTE";
        }
        public string cmdGetRSSI()
        {
            return "RSSI";
        }
    }
}
