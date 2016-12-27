namespace Console
{
    partial class ConsoleForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxDigitalOcean = new System.Windows.Forms.GroupBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.lblLastKnownIp = new System.Windows.Forms.Label();
            this.lblQueryInterval = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQueryIntevalKey = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxDigitalOcean
            // 
            this.gbxDigitalOcean.Location = new System.Drawing.Point(282, 13);
            this.gbxDigitalOcean.Name = "gbxDigitalOcean";
            this.gbxDigitalOcean.Size = new System.Drawing.Size(251, 174);
            this.gbxDigitalOcean.TabIndex = 1;
            this.gbxDigitalOcean.TabStop = false;
            this.gbxDigitalOcean.Text = "DigitalOcean";
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.textBox2);
            this.gbxSettings.Controls.Add(this.lblQueryIntevalKey);
            this.gbxSettings.Controls.Add(this.textBox1);
            this.gbxSettings.Controls.Add(this.lblQueryInterval);
            this.gbxSettings.Controls.Add(this.lblLastKnownIp);
            this.gbxSettings.Location = new System.Drawing.Point(13, 13);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(263, 94);
            this.gbxSettings.TabIndex = 2;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Application Settings";
            // 
            // lblLastKnownIp
            // 
            this.lblLastKnownIp.AutoSize = true;
            this.lblLastKnownIp.Location = new System.Drawing.Point(7, 60);
            this.lblLastKnownIp.Name = "lblLastKnownIp";
            this.lblLastKnownIp.Size = new System.Drawing.Size(97, 13);
            this.lblLastKnownIp.TabIndex = 0;
            this.lblLastKnownIp.Text = "Current IP address:";
            // 
            // lblQueryInterval
            // 
            this.lblQueryInterval.AutoSize = true;
            this.lblQueryInterval.Location = new System.Drawing.Point(6, 26);
            this.lblQueryInterval.Name = "lblQueryInterval";
            this.lblQueryInterval.Size = new System.Drawing.Size(75, 13);
            this.lblQueryInterval.TabIndex = 1;
            this.lblQueryInterval.Text = "Query interval:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblQueryIntevalKey
            // 
            this.lblQueryIntevalKey.AutoSize = true;
            this.lblQueryIntevalKey.Location = new System.Drawing.Point(155, 29);
            this.lblQueryIntevalKey.Name = "lblQueryIntevalKey";
            this.lblQueryIntevalKey.Size = new System.Drawing.Size(43, 13);
            this.lblQueryIntevalKey.TabIndex = 3;
            this.lblQueryIntevalKey.Text = "minutes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 4;
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 201);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxDigitalOcean);
            this.Controls.Add(this.btnSave);
            this.Name = "ConsoleForm";
            this.Text = "Console";
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxDigitalOcean;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblQueryIntevalKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQueryInterval;
        private System.Windows.Forms.Label lblLastKnownIp;
    }
}

