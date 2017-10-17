namespace VirusV8
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.monoFlat_Label1 = new MonoFlat.Class1.MonoFlat_Label();
            this.Button_ServerStart = new System.Windows.Forms.Button();
            this.Label_Titel = new System.Windows.Forms.Label();
            this.timerTryConnect = new System.Windows.Forms.Timer(this.components);
            this.timerTryReceive = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinner1.CustomBackground = true;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(77, 133);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(168, 165);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner1.StyleManager = null;
            this.metroProgressSpinner1.TabIndex = 5;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner1.Visible = false;
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(97, 75);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(131, 15);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Warte auf Verbindung...";
            this.monoFlat_Label1.Visible = false;
            // 
            // Button_ServerStart
            // 
            this.Button_ServerStart.BackColor = System.Drawing.Color.OliveDrab;
            this.Button_ServerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ServerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ServerStart.Location = new System.Drawing.Point(100, 114);
            this.Button_ServerStart.Name = "Button_ServerStart";
            this.Button_ServerStart.Size = new System.Drawing.Size(122, 55);
            this.Button_ServerStart.TabIndex = 3;
            this.Button_ServerStart.Text = "STARTEN";
            this.Button_ServerStart.UseVisualStyleBackColor = false;
            this.Button_ServerStart.Click += new System.EventHandler(this.Button_ServerStart_Click);
            // 
            // Label_Titel
            // 
            this.Label_Titel.AutoSize = true;
            this.Label_Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titel.Location = new System.Drawing.Point(37, 23);
            this.Label_Titel.Name = "Label_Titel";
            this.Label_Titel.Size = new System.Drawing.Size(245, 31);
            this.Label_Titel.TabIndex = 0;
            this.Label_Titel.Text = "Server Initialisieren";
            // 
            // timerTryConnect
            // 
            this.timerTryConnect.Enabled = true;
            this.timerTryConnect.Interval = 1000;
            this.timerTryConnect.Tick += new System.EventHandler(this.timerTryConnect_Tick_1);
            // 
            // timerTryReceive
            // 
            this.timerTryReceive.Interval = 10;
            this.timerTryReceive.Tick += new System.EventHandler(this.timerTryReceive_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 306);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.Button_ServerStart);
            this.Controls.Add(this.Label_Titel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VirusV8-Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MonoFlat.Class1.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.Button Button_ServerStart;
        private System.Windows.Forms.Label Label_Titel;
        public System.Windows.Forms.Timer timerTryConnect;
        public System.Windows.Forms.Timer timerTryReceive;
    }
}

