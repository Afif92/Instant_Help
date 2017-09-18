namespace Instant_Help
{
    partial class Medical
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
            this.btnNearbyHospital = new System.Windows.Forms.Button();
            this.btnEmergencyMedicalContact = new System.Windows.Forms.Button();
            this.btnAmbulanceService = new System.Windows.Forms.Button();
            this.btnPrimaryHelp = new System.Windows.Forms.Button();
            this.btnMedicalCenterBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNearbyHospital
            // 
            this.btnNearbyHospital.BackColor = System.Drawing.Color.Indigo;
            this.btnNearbyHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNearbyHospital.Location = new System.Drawing.Point(26, 102);
            this.btnNearbyHospital.Name = "btnNearbyHospital";
            this.btnNearbyHospital.Size = new System.Drawing.Size(129, 60);
            this.btnNearbyHospital.TabIndex = 0;
            this.btnNearbyHospital.Text = "Nearby Hospital";
            this.btnNearbyHospital.UseVisualStyleBackColor = false;
            // 
            // btnEmergencyMedicalContact
            // 
            this.btnEmergencyMedicalContact.BackColor = System.Drawing.Color.Indigo;
            this.btnEmergencyMedicalContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyMedicalContact.Location = new System.Drawing.Point(206, 102);
            this.btnEmergencyMedicalContact.Name = "btnEmergencyMedicalContact";
            this.btnEmergencyMedicalContact.Size = new System.Drawing.Size(131, 60);
            this.btnEmergencyMedicalContact.TabIndex = 1;
            this.btnEmergencyMedicalContact.Text = "Emergency Contact";
            this.btnEmergencyMedicalContact.UseVisualStyleBackColor = false;
            // 
            // btnAmbulanceService
            // 
            this.btnAmbulanceService.BackColor = System.Drawing.Color.Indigo;
            this.btnAmbulanceService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbulanceService.Location = new System.Drawing.Point(26, 245);
            this.btnAmbulanceService.Name = "btnAmbulanceService";
            this.btnAmbulanceService.Size = new System.Drawing.Size(129, 59);
            this.btnAmbulanceService.TabIndex = 2;
            this.btnAmbulanceService.Text = "Ambulance Service";
            this.btnAmbulanceService.UseVisualStyleBackColor = false;
            this.btnAmbulanceService.Click += new System.EventHandler(this.btnAmbulanceService_Click);
            // 
            // btnPrimaryHelp
            // 
            this.btnPrimaryHelp.BackColor = System.Drawing.Color.Indigo;
            this.btnPrimaryHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimaryHelp.Location = new System.Drawing.Point(206, 245);
            this.btnPrimaryHelp.Name = "btnPrimaryHelp";
            this.btnPrimaryHelp.Size = new System.Drawing.Size(131, 59);
            this.btnPrimaryHelp.TabIndex = 3;
            this.btnPrimaryHelp.Text = "Primary Help";
            this.btnPrimaryHelp.UseVisualStyleBackColor = false;
            // 
            // btnMedicalCenterBack
            // 
            this.btnMedicalCenterBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMedicalCenterBack.Location = new System.Drawing.Point(60, 412);
            this.btnMedicalCenterBack.Name = "btnMedicalCenterBack";
            this.btnMedicalCenterBack.Size = new System.Drawing.Size(75, 23);
            this.btnMedicalCenterBack.TabIndex = 4;
            this.btnMedicalCenterBack.Text = "Back";
            this.btnMedicalCenterBack.UseVisualStyleBackColor = true;
            this.btnMedicalCenterBack.Click += new System.EventHandler(this.btnMedicalCenterBack_Click);
            // 
            // Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(381, 504);
            this.Controls.Add(this.btnMedicalCenterBack);
            this.Controls.Add(this.btnPrimaryHelp);
            this.Controls.Add(this.btnAmbulanceService);
            this.Controls.Add(this.btnEmergencyMedicalContact);
            this.Controls.Add(this.btnNearbyHospital);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Medical";
            this.Text = "Medical";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNearbyHospital;
        private System.Windows.Forms.Button btnEmergencyMedicalContact;
        private System.Windows.Forms.Button btnAmbulanceService;
        private System.Windows.Forms.Button btnPrimaryHelp;
        private System.Windows.Forms.Button btnMedicalCenterBack;
    }
}