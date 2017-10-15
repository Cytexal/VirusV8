namespace VirusV8_Client
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
            this.timerTryConnect = new System.Windows.Forms.Timer(this.components);
            this.timerTryReceive = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button192168178xx = new System.Windows.Forms.Button();
            this.button101000xx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerTryConnect
            // 
            this.timerTryConnect.Interval = 1000;
            this.timerTryConnect.Tick += new System.EventHandler(this.timerTryConnect_Tick);
            // 
            // timerTryReceive
            // 
            this.timerTryReceive.Interval = 30;
            this.timerTryReceive.Tick += new System.EventHandler(this.timerTryReceive_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button192168178xx
            // 
            this.button192168178xx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button192168178xx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button192168178xx.Location = new System.Drawing.Point(12, 45);
            this.button192168178xx.Name = "button192168178xx";
            this.button192168178xx.Size = new System.Drawing.Size(168, 23);
            this.button192168178xx.TabIndex = 2;
            this.button192168178xx.Text = "192.168.178.xx";
            this.button192168178xx.UseVisualStyleBackColor = true;
            this.button192168178xx.Click += new System.EventHandler(this.button192168178xx_Click);
            // 
            // button101000xx
            // 
            this.button101000xx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button101000xx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button101000xx.Location = new System.Drawing.Point(12, 74);
            this.button101000xx.Name = "button101000xx";
            this.button101000xx.Size = new System.Drawing.Size(168, 23);
            this.button101000xx.TabIndex = 3;
            this.button101000xx.Text = "10.100.0.xx";
            this.button101000xx.UseVisualStyleBackColor = true;
            this.button101000xx.Click += new System.EventHandler(this.button101000xx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(267, 105);
            this.Controls.Add(this.button101000xx);
            this.Controls.Add(this.button192168178xx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTryConnect;
        private System.Windows.Forms.Timer timerTryReceive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button192168178xx;
        private System.Windows.Forms.Button button101000xx;
    }
}

