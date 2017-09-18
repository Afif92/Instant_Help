namespace Instant_Help
{
    partial class Police
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
            this.btnNearbyPoliceCenter = new System.Windows.Forms.Button();
            this.btnCallNow = new System.Windows.Forms.Button();
            this.btnSendVoiceMail = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMailNow = new System.Windows.Forms.Button();
            this.btnPoliceCenterBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNearbyPoliceCenter
            // 
            this.btnNearbyPoliceCenter.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNearbyPoliceCenter.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNearbyPoliceCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNearbyPoliceCenter.Location = new System.Drawing.Point(23, 79);
            this.btnNearbyPoliceCenter.Name = "btnNearbyPoliceCenter";
            this.btnNearbyPoliceCenter.Size = new System.Drawing.Size(135, 61);
            this.btnNearbyPoliceCenter.TabIndex = 0;
            this.btnNearbyPoliceCenter.Text = "Nearby Police Center";
            this.btnNearbyPoliceCenter.UseVisualStyleBackColor = false;
            this.btnNearbyPoliceCenter.Click += new System.EventHandler(this.btnNearbyPoliceCenter_Click);
            // 
            // btnCallNow
            // 
            this.btnCallNow.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCallNow.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCallNow.Location = new System.Drawing.Point(229, 79);
            this.btnCallNow.Name = "btnCallNow";
            this.btnCallNow.Size = new System.Drawing.Size(125, 61);
            this.btnCallNow.TabIndex = 1;
            this.btnCallNow.Text = "Call Now";
            this.btnCallNow.UseVisualStyleBackColor = false;
            // 
            // btnSendVoiceMail
            // 
            this.btnSendVoiceMail.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSendVoiceMail.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendVoiceMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendVoiceMail.Location = new System.Drawing.Point(23, 209);
            this.btnSendVoiceMail.Name = "btnSendVoiceMail";
            this.btnSendVoiceMail.Size = new System.Drawing.Size(135, 69);
            this.btnSendVoiceMail.TabIndex = 2;
            this.btnSendVoiceMail.Text = "Send Voice Mail";
            this.btnSendVoiceMail.UseVisualStyleBackColor = false;
            this.btnSendVoiceMail.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(229, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Send Video Mail";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnMailNow
            // 
            this.btnMailNow.BackColor = System.Drawing.Color.BlueViolet;
            this.btnMailNow.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMailNow.Location = new System.Drawing.Point(136, 322);
            this.btnMailNow.Name = "btnMailNow";
            this.btnMailNow.Size = new System.Drawing.Size(136, 66);
            this.btnMailNow.TabIndex = 4;
            this.btnMailNow.Text = "Mail Now";
            this.btnMailNow.UseVisualStyleBackColor = false;
            this.btnMailNow.Click += new System.EventHandler(this.btnMailNow_Click);
            // 
            // btnPoliceCenterBack
            // 
            this.btnPoliceCenterBack.Location = new System.Drawing.Point(55, 440);
            this.btnPoliceCenterBack.Name = "btnPoliceCenterBack";
            this.btnPoliceCenterBack.Size = new System.Drawing.Size(75, 23);
            this.btnPoliceCenterBack.TabIndex = 5;
            this.btnPoliceCenterBack.Text = "Back";
            this.btnPoliceCenterBack.UseVisualStyleBackColor = true;
            this.btnPoliceCenterBack.Click += new System.EventHandler(this.btnPoliceCenterBack_Click);
            // 
            // Police
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(381, 504);
            this.Controls.Add(this.btnPoliceCenterBack);
            this.Controls.Add(this.btnMailNow);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSendVoiceMail);
            this.Controls.Add(this.btnCallNow);
            this.Controls.Add(this.btnNearbyPoliceCenter);
            this.Name = "Police";
            this.Text = "Police";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNearbyPoliceCenter;
        private System.Windows.Forms.Button btnCallNow;
        private System.Windows.Forms.Button btnSendVoiceMail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMailNow;
        private System.Windows.Forms.Button btnPoliceCenterBack;
    }
}