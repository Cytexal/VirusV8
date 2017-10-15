using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusV8_Client
{
    public partial class PopUpMessageViewer : Form
    {
        public PopUpMessageViewer()
        {
            InitializeComponent();
        }

        private void PopUpMessageViewer_Load(object sender, EventArgs e)
        {
            timerZeit.Interval = Form1.Vars.Anzeigezeit * 1000;
            timerZeit.Enabled = true;
            this.Location = new Point(30, 30);
            labelMessage.Text = Form1.Vars.PopUpMessageText;
        }

        private void timerZeit_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
