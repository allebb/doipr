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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblARecordUpdate = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.ComboBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.txtServiceStatus = new System.Windows.Forms.TextBox();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.txtLastUpdatedAt = new System.Windows.Forms.TextBox();
            this.lblLastUpdateAt = new System.Windows.Forms.Label();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.lblQueryIntevalKey = new System.Windows.Forms.Label();
            this.txtQueryInterval = new System.Windows.Forms.TextBox();
            this.lblQueryInterval = new System.Windows.Forms.Label();
            this.lblLastKnownIp = new System.Windows.Forms.Label();
            this.gbxDigitalOcean.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxDigitalOcean
            // 
            this.gbxDigitalOcean.Controls.Add(this.txtToken);
            this.gbxDigitalOcean.Controls.Add(this.lblToken);
            this.gbxDigitalOcean.Controls.Add(this.lblARecordUpdate);
            this.gbxDigitalOcean.Controls.Add(this.txtUpdate);
            this.gbxDigitalOcean.Controls.Add(this.btnRetrieve);
            this.gbxDigitalOcean.Controls.Add(this.lblDomain);
            this.gbxDigitalOcean.Controls.Add(this.txtDomain);
            this.gbxDigitalOcean.Location = new System.Drawing.Point(282, 13);
            this.gbxDigitalOcean.Name = "gbxDigitalOcean";
            this.gbxDigitalOcean.Size = new System.Drawing.Size(251, 135);
            this.gbxDigitalOcean.TabIndex = 1;
            this.gbxDigitalOcean.TabStop = false;
            this.gbxDigitalOcean.Text = "DigitalOcean";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(59, 17);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(186, 20);
            this.txtToken.TabIndex = 6;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(10, 20);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(41, 13);
            this.lblToken.TabIndex = 5;
            this.lblToken.Text = "Token:";
            // 
            // lblARecordUpdate
            // 
            this.lblARecordUpdate.AutoSize = true;
            this.lblARecordUpdate.Location = new System.Drawing.Point(6, 107);
            this.lblARecordUpdate.Name = "lblARecordUpdate";
            this.lblARecordUpdate.Size = new System.Drawing.Size(45, 13);
            this.lblARecordUpdate.TabIndex = 4;
            this.lblARecordUpdate.Text = "Update:";
            // 
            // txtUpdate
            // 
            this.txtUpdate.FormattingEnabled = true;
            this.txtUpdate.Location = new System.Drawing.Point(58, 104);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(124, 21);
            this.txtUpdate.TabIndex = 3;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(188, 77);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(57, 23);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(6, 81);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 1;
            this.lblDomain.Text = "Domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(58, 78);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(124, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.txtServiceStatus);
            this.gbxSettings.Controls.Add(this.lblServiceStatus);
            this.gbxSettings.Controls.Add(this.txtLastUpdatedAt);
            this.gbxSettings.Controls.Add(this.lblLastUpdateAt);
            this.gbxSettings.Controls.Add(this.txtCurrentAddress);
            this.gbxSettings.Controls.Add(this.lblQueryIntevalKey);
            this.gbxSettings.Controls.Add(this.txtQueryInterval);
            this.gbxSettings.Controls.Add(this.lblQueryInterval);
            this.gbxSettings.Controls.Add(this.lblLastKnownIp);
            this.gbxSettings.Location = new System.Drawing.Point(13, 13);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(263, 161);
            this.gbxSettings.TabIndex = 2;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Application Settings";
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.Location = new System.Drawing.Point(110, 109);
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.ReadOnly = true;
            this.txtServiceStatus.Size = new System.Drawing.Size(147, 20);
            this.txtServiceStatus.TabIndex = 8;
            this.txtServiceStatus.Text = "Running...";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Location = new System.Drawing.Point(9, 112);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(79, 13);
            this.lblServiceStatus.TabIndex = 7;
            this.lblServiceStatus.Text = "Service Status:";
            // 
            // txtLastUpdatedAt
            // 
            this.txtLastUpdatedAt.Location = new System.Drawing.Point(110, 83);
            this.txtLastUpdatedAt.Name = "txtLastUpdatedAt";
            this.txtLastUpdatedAt.ReadOnly = true;
            this.txtLastUpdatedAt.Size = new System.Drawing.Size(147, 20);
            this.txtLastUpdatedAt.TabIndex = 6;
            // 
            // lblLastUpdateAt
            // 
            this.lblLastUpdateAt.AutoSize = true;
            this.lblLastUpdateAt.Location = new System.Drawing.Point(9, 86);
            this.lblLastUpdateAt.Name = "lblLastUpdateAt";
            this.lblLastUpdateAt.Size = new System.Drawing.Size(87, 13);
            this.lblLastUpdateAt.TabIndex = 5;
            this.lblLastUpdateAt.Text = "Last checked at:";
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Location = new System.Drawing.Point(110, 57);
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.ReadOnly = true;
            this.txtCurrentAddress.Size = new System.Drawing.Size(147, 20);
            this.txtCurrentAddress.TabIndex = 4;
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
            // txtQueryInterval
            // 
            this.txtQueryInterval.Location = new System.Drawing.Point(88, 26);
            this.txtQueryInterval.Name = "txtQueryInterval";
            this.txtQueryInterval.Size = new System.Drawing.Size(61, 20);
            this.txtQueryInterval.TabIndex = 2;
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
            // lblLastKnownIp
            // 
            this.lblLastKnownIp.AutoSize = true;
            this.lblLastKnownIp.Location = new System.Drawing.Point(7, 60);
            this.lblLastKnownIp.Name = "lblLastKnownIp";
            this.lblLastKnownIp.Size = new System.Drawing.Size(97, 13);
            this.lblLastKnownIp.TabIndex = 0;
            this.lblLastKnownIp.Text = "Current IP address:";
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 186);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxDigitalOcean);
            this.Controls.Add(this.btnSave);
            this.Name = "ConsoleForm";
            this.Text = "Console";
            this.gbxDigitalOcean.ResumeLayout(false);
            this.gbxDigitalOcean.PerformLayout();
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxDigitalOcean;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.Label lblQueryIntevalKey;
        private System.Windows.Forms.TextBox txtQueryInterval;
        private System.Windows.Forms.Label lblQueryInterval;
        private System.Windows.Forms.Label lblLastKnownIp;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblARecordUpdate;
        private System.Windows.Forms.ComboBox txtUpdate;
        private System.Windows.Forms.TextBox txtLastUpdatedAt;
        private System.Windows.Forms.Label lblLastUpdateAt;
        private System.Windows.Forms.TextBox txtServiceStatus;
        private System.Windows.Forms.Label lblServiceStatus;
    }
}

