namespace Instant_Help
{
    partial class Index
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
            this.btnPoliceCenter = new System.Windows.Forms.Button();
            this.btnEmergencyHelpLine = new System.Windows.Forms.Button();
            this.btnMedicalCenter = new System.Windows.Forms.Button();
            this.btnFireHelp = new System.Windows.Forms.Button();
            this.btnNeccessaryContact = new System.Windows.Forms.Button();
            this.btnEditDatabase = new System.Windows.Forms.Button();
            this.btnIndexBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPoliceCenter
            // 
            this.btnPoliceCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoliceCenter.Location = new System.Drawing.Point(206, 56);
            this.btnPoliceCenter.Name = "btnPoliceCenter";
            this.btnPoliceCenter.Size = new System.Drawing.Size(121, 52);
            this.btnPoliceCenter.TabIndex = 1;
            this.btnPoliceCenter.Text = "Police Center";
            this.btnPoliceCenter.UseVisualStyleBackColor = true;
            this.btnPoliceCenter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmergencyHelpLine
            // 
            this.btnEmergencyHelpLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyHelpLine.Location = new System.Drawing.Point(39, 56);
            this.btnEmergencyHelpLine.Name = "btnEmergencyHelpLine";
            this.btnEmergencyHelpLine.Size = new System.Drawing.Size(119, 52);
            this.btnEmergencyHelpLine.TabIndex = 1;
            this.btnEmergencyHelpLine.Text = "Emergency HelpLine";
            this.btnEmergencyHelpLine.UseVisualStyleBackColor = true;
            this.btnEmergencyHelpLine.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedicalCenter
            // 
            this.btnMedicalCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalCenter.Location = new System.Drawing.Point(206, 146);
            this.btnMedicalCenter.Name = "btnMedicalCenter";
            this.btnMedicalCenter.Size = new System.Drawing.Size(121, 53);
            this.btnMedicalCenter.TabIndex = 1;
            this.btnMedicalCenter.Text = "Medical Center";
            this.btnMedicalCenter.UseVisualStyleBackColor = true;
            this.btnMedicalCenter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFireHelp
            // 
            this.btnFireHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireHelp.Location = new System.Drawing.Point(39, 146);
            this.btnFireHelp.Name = "btnFireHelp";
            this.btnFireHelp.Size = new System.Drawing.Size(119, 53);
            this.btnFireHelp.TabIndex = 1;
            this.btnFireHelp.Text = "Fire Help";
            this.btnFireHelp.UseVisualStyleBackColor = true;
            this.btnFireHelp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNeccessaryContact
            // 
            this.btnNeccessaryContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeccessaryContact.Location = new System.Drawing.Point(95, 257);
            this.btnNeccessaryContact.Name = "btnNeccessaryContact";
            this.btnNeccessaryContact.Size = new System.Drawing.Size(128, 51);
            this.btnNeccessaryContact.TabIndex = 1;
            this.btnNeccessaryContact.Text = "Neccessary Contact";
            this.btnNeccessaryContact.UseVisualStyleBackColor = true;
            this.btnNeccessaryContact.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditDatabase
            // 
            this.btnEditDatabase.Location = new System.Drawing.Point(233, 368);
            this.btnEditDatabase.Name = "btnEditDatabase";
            this.btnEditDatabase.Size = new System.Drawing.Size(119, 23);
            this.btnEditDatabase.TabIndex = 2;
            this.btnEditDatabase.Text = "Edit Database";
            this.btnEditDatabase.UseVisualStyleBackColor = true;
            this.btnEditDatabase.Visible = false;
            this.btnEditDatabase.Click += new System.EventHandler(this.btnEditDatabase_Click);
            // 
            // btnIndexBack
            // 
            this.btnIndexBack.Location = new System.Drawing.Point(39, 367);
            this.btnIndexBack.Name = "btnIndexBack";
            this.btnIndexBack.Size = new System.Drawing.Size(75, 23);
            this.btnIndexBack.TabIndex = 3;
            this.btnIndexBack.Text = "Back";
            this.btnIndexBack.UseVisualStyleBackColor = true;
            this.btnIndexBack.Click += new System.EventHandler(this.btnIndexBack_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(395, 448);
            this.Controls.Add(this.btnIndexBack);
            this.Controls.Add(this.btnEditDatabase);
            this.Controls.Add(this.btnNeccessaryContact);
            this.Controls.Add(this.btnFireHelp);
            this.Controls.Add(this.btnMedicalCenter);
            this.Controls.Add(this.btnEmergencyHelpLine);
            this.Controls.Add(this.btnPoliceCenter);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPoliceCenter;
        private System.Windows.Forms.Button btnEmergencyHelpLine;
        private System.Windows.Forms.Button btnMedicalCenter;
        private System.Windows.Forms.Button btnFireHelp;
        private System.Windows.Forms.Button btnNeccessaryContact;
        private System.Windows.Forms.Button btnEditDatabase;
        private System.Windows.Forms.Button btnIndexBack;
    }
}