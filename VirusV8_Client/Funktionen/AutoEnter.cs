using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VirusV8_Client
{
    class AutoEnter
    {
        public System.Windows.Forms.Timer timer;
        public AutoEnter()
        {
         timer= new System.Windows.Forms.Timer();
         timer.Interval = 1000;
         timer.Tick += T_Tick;
        }

        public void Enable()
        {
            
            timer.Enabled = true;
        }

        private static void T_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        public void Disable()
        {
            timer.Enabled = false;
        }

    }
}
