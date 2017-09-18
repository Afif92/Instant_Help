namespace Instant_Help
{
    partial class FireIndex
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
            this.btnNearbyFireStation = new System.Windows.Forms.Button();
            this.btnEmergencyFireContact = new System.Windows.Forms.Button();
            this.btnSecurityInfo = new System.Windows.Forms.Button();
            this.btnFireIndexBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNearbyFireStation
            // 
            this.btnNearbyFireStation.BackColor = System.Drawing.Color.Cyan;
            this.btnNearbyFireStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNearbyFireStation.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNearbyFireStation.Location = new System.Drawing.Point(12, 110);
            this.btnNearbyFireStation.Name = "btnNearbyFireStation";
            this.btnNearbyFireStation.Size = new System.Drawing.Size(130, 64);
            this.btnNearbyFireStation.TabIndex = 0;
            this.btnNearbyFireStation.Text = "Nearby Fire Station";
            this.btnNearbyFireStation.UseVisualStyleBackColor = false;
            // 
            // btnEmergencyFireContact
            // 
            this.btnEmergencyFireContact.BackColor = System.Drawing.Color.Cyan;
            this.btnEmergencyFireContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyFireContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEmergencyFireContact.Location = new System.Drawing.Point(211, 110);
            this.btnEmergencyFireContact.Name = "btnEmergencyFireContact";
            this.btnEmergencyFireContact.Size = new System.Drawing.Size(129, 64);
            this.btnEmergencyFireContact.TabIndex = 3;
            this.btnEmergencyFireContact.Text = "Emergency Contact";
            this.btnEmergencyFireContact.UseVisualStyleBackColor = false;
            // 
            // btnSecurityInfo
            // 
            this.btnSecurityInfo.BackColor = System.Drawing.Color.Cyan;
            this.btnSecurityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurityInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSecurityInfo.Location = new System.Drawing.Point(116, 258);
            this.btnSecurityInfo.Name = "btnSecurityInfo";
            this.btnSecurityInfo.Size = new System.Drawing.Size(129, 64);
            this.btnSecurityInfo.TabIndex = 3;
            this.btnSecurityInfo.Text = "Security Info";
            this.btnSecurityInfo.UseVisualStyleBackColor = false;
            // 
            // btnFireIndexBack
            // 
            this.btnFireIndexBack.Location = new System.Drawing.Point(41, 448);
            this.btnFireIndexBack.Name = "btnFireIndexBack";
            this.btnFireIndexBack.Size = new System.Drawing.Size(75, 23);
            this.btnFireIndexBack.TabIndex = 4;
            this.btnFireIndexBack.Text = "Back";
            this.btnFireIndexBack.UseVisualStyleBackColor = true;
            this.btnFireIndexBack.Click += new System.EventHandler(this.btnFireIndexBack_Click);
            // 
            // FireIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(381, 504);
            this.Controls.Add(this.btnFireIndexBack);
            this.Controls.Add(this.btnSecurityInfo);
            this.Controls.Add(this.btnEmergencyFireContact);
            this.Controls.Add(this.btnNearbyFireStation);
            this.Name = "FireIndex";
            this.Text = "FireIndex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNearbyFireStation;
        private System.Windows.Forms.Button btnEmergencyFireContact;
        private System.Windows.Forms.Button btnSecurityInfo;
        private System.Windows.Forms.Button btnFireIndexBack;
    }
}