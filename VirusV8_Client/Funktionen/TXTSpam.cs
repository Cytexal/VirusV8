﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VirusV8_Client.Funktionen
{
    public class TXTSpam
    {
        public TXTSpam()
        {
            for (int i = 0; i < 150; i++)
            {
                try
                {
                    File.Create(Application.StartupPath + @"\Arsch" + i.ToString() + ".txt");
                }
                catch
                {
                }
            }
        }
    }
}
