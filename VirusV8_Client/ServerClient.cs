using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusV8_Client
{
    public class ServerClient
    {
        Socket socket;
        /// <summary>
        /// Port, auf dem der Server auf Clientverbindungen wartet
        /// </summary>
        /// Anzahl Millisekunden in Warteschleifen
        /// </summary>
        public const int sleepTime = 200;
        /// <summary>
        /// IP-Adresse, an der auf Verbindungen gewartet werden soll.
        /// Standardmässig wird auf allen Schnittstellen gewartet.
        /// </summary>
        public IPAddress ipAddress = IPAddress.Any;

        /// <summary>
        /// Der Standardkonstruktor
        /// </summary>
        public ServerClient(int Port)
        {
            // Alle Netzwerk-Schnittstellen abhören
            TcpListener listener = new TcpListener(ipAddress, Port);
            System.Console.WriteLine("Listening on port " + Port + "...");
            try
            {
                BackgroundWorker bw = new BackgroundWorker();
                bw.RunWorkerAsync();
                bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;
                    listener.Start();
                    // Warten auf Verbindung
                    while (!listener.Pending()) { Thread.Sleep(sleepTime); }
                    // Verbindung annehmen
                    Socket newSocket = listener.AcceptSocket();
                    socket = newSocket;
                    // Mitteilung bzgl. neuer Clientverbindung
                    System.Console.WriteLine("Neue Client-Verbindung (" +
                                "IP: " + newSocket.RemoteEndPoint + ", " +
                                "Port " + ((IPEndPoint)newSocket.LocalEndPoint).Port.ToString() + ")");

                });

                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                delegate (object o, RunWorkerCompletedEventArgs args)
                {
                  
                });
                // Verbindungsannahme aktivieren
                //dassadsda
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler bei Verbindungserkennung", ex);
            }
        }


        public int send(Byte[] data)
        {
            if (socket == null) return 0;
            if (data == null) return 0;
            if (data.Length <= 0) return 0;
            try
            {
                //int offset = 0;// Quelldaten-Offset
                //int lastsend = 0;// Anzahl der zuletzt übertragenen Bytes
                //int toSend = 0;// Anzahl der zu sendenden Bytes
                return socket.Send(data);
            }
            catch (SocketException ex)
            {
                socket.Close();
                socket = null;
                return 0;
            }
            catch (ObjectDisposedException ex)
            {
                socket.Close();
                socket = null;
                return 0;
            }
            catch (Exception ex)
            {
                socket.Close();
                socket = null;
                return 0;
            }
        }


    }
}