using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusV8
{
    public partial class PopUpNachrichtEditor : Form
    {
        public PopUpNachrichtEditor()
        {
            InitializeComponent();
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            PopUpNachrichtEditor.Vars.Abbruch = true;
            this.Hide();
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                PopUpNachrichtEditor.Vars.PopUpText = richTextBoxMessage.Text;
                PopUpNachrichtEditor.Vars.Anzeigezeit = Convert.ToInt32(numericUpDownAnzeigezeit.Value);
                PopUpNachrichtEditor.Vars.Ready = true;
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Fehler");
                PopUpNachrichtEditor.Vars.Abbruch = true;
                this.Hide();
            }
        }

        public struct Vars
        {
            public static string PopUpText;
            public static int Anzeigezeit;
            public static bool Ready;
            public static bool Abbruch;
            public static Image BildÜT;
        }

        private void PopUpNachrichtEditor_Load(object sender, EventArgs e)
        {
            PopUpNachrichtEditor.Vars.Ready = false;
            PopUpNachrichtEditor.Vars.Abbruch = false;
        }
    }
}
