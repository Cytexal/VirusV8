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
using System.IO;

namespace VirusV8
{
    public partial class Form1 : Form
    {
        Socket ImageSocket;
        Server server;
        public IPEndPoint remoteIpEndPoint;
        public Form1()
        {
            InitializeComponent();
        }

        public void enableConnectTimer()
        {
            this.timerTryConnect.Enabled = true;
        }

        private void Button_ServerStart_Click(object sender, EventArgs e)
        {
            server = new Server(1000);
            
            this.Size = new Size(344, 345);
            monoFlat_Label1.Show();
            Button_ServerStart.Hide();
            metroProgressSpinner1.Show();
            
          
            //  timerTryConnect.Enabled = true;
        }


        private void timerTryConnect_Tick(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(344, 222);
        }

        private void timerTryConnect_Tick_1(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(remoteIpEndPoint.Address.ToString(), 1001);//IP CHANGE
                ImageSocket = client.getsocket();
                timerTryConnect.Enabled = false;
                timerTryReceive.Enabled = true;

            }
            catch (Exception exe)
            {

            }
        }

        private void timerTryReceive_Tick(object sender, EventArgs e)
        {
            byte[] array = receive();
            if (array != null)
            {
                try
                { 
                PopUpNachrichtEditor.Vars.BildÜT = byteArrayToImage(array);
                }
                catch
                {

                }
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] receive()
        {
            try
            {
                int TimeOut = 500;
                int SleepTime = 50;
                int cnt = 0;
                MemoryStream mem = new MemoryStream();// Empfangspuffer
                byte[] buffer = new byte[1024];
                while (cnt < (TimeOut / SleepTime))
                {
                    while (ImageSocket.Available > 0)
                    {
                        int bytesRead = ImageSocket.Receive(buffer, buffer.Length, SocketFlags.None);
                        if (bytesRead <= 0) continue;
                        mem.Write(buffer, 0, bytesRead);
                    }
                    //Thread.Sleep(SleepTime);
                    if (mem.Length > 0 && ImageSocket.Available == 0)
                    {
                        return mem.ToArray();
                    }
                    else
                    {
                        cnt++;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
