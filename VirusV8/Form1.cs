using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusV8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ServerStart_Click(object sender, EventArgs e)
        {
            Server server = new Server(1000);
            this.Size = new Size(344, 345);
            monoFlat_Label1.Show();
            Button_ServerStart.Hide();
            metroProgressSpinner1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(344, 222);
        }
    }
}
