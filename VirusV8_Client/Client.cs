﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Security;

namespace VirusV8_Client
{
    public class Client
    {
        public Socket socket = null;

        /// <summary>
        /// Stellt eine Verbindung zum angegebenen Server her
        /// </summary>
        /// <param name="ipAddress">IP-Adresse oder Hostname des Servers</param>
        /// <param name="port">Port-Nummer des Servers</param>
        public Client(String Address, int port)
        {
            try
            {

                //H/H/DS
                IPHostEntry hostInfo = Dns.GetHostByName(Address);
                System.Net.IPEndPoint ep = new System.Net.IPEndPoint(hostInfo.AddressList[0], port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ep);
            }
            catch (SecurityException ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server, evtl. verursacht durch eine Firewall oder ähnliche Schutzmechanismen", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server", ex);
            }
        }
    }
}
