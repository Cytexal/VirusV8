namespace VirusV8
{
    partial class PopUpNachrichtEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monoFlat_Button1 = new MonoFlat.Class1.MonoFlat_Button();
            this.monoFlat_Button2 = new MonoFlat.Class1.MonoFlat_Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDownAnzeigezeit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzeigezeit)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(419, 180);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button1.TabIndex = 0;
            this.monoFlat_Button1.Text = "Schicken";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(267, 180);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button2.TabIndex = 1;
            this.monoFlat_Button2.Text = "Abbrechen";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(3, 27);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(570, 147);
            this.richTextBoxMessage.TabIndex = 2;
            this.richTextBoxMessage.Text = "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Text:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // numericUpDownAnzeigezeit
            // 
            this.numericUpDownAnzeigezeit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAnzeigezeit.Location = new System.Drawing.Point(107, 188);
            this.numericUpDownAnzeigezeit.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownAnzeigezeit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAnzeigezeit.Name = "numericUpDownAnzeigezeit";
            this.numericUpDownAnzeigezeit.Size = new System.Drawing.Size(46, 29);
            this.numericUpDownAnzeigezeit.TabIndex = 4;
            this.numericUpDownAnzeigezeit.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anzeigezeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "(s)";
            // 
            // PopUpNachrichtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAnzeigezeit);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.monoFlat_Button2);
            this.Controls.Add(this.monoFlat_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PopUpNachrichtEditor";
            this.Text = "PopUpNachrichtEditor";
            this.Load += new System.EventHandler(this.PopUpNachrichtEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzeigezeit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonoFlat.Class1.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.Class1.MonoFlat_Button monoFlat_Button2;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDownAnzeigezeit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}