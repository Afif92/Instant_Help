namespace Instant_Help
{
    partial class Send_Mail
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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMailBody = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.txtBoxAttachFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(142, 26);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSubject.TabIndex = 0;
            // 
            // txtMailBody
            // 
            this.txtMailBody.Location = new System.Drawing.Point(106, 95);
            this.txtMailBody.Multiline = true;
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.Size = new System.Drawing.Size(334, 215);
            this.txtMailBody.TabIndex = 1;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(284, 429);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(128, 23);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(29, 367);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(75, 23);
            this.btnAttachFile.TabIndex = 3;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // txtBoxAttachFile
            // 
            this.txtBoxAttachFile.Location = new System.Drawing.Point(128, 367);
            this.txtBoxAttachFile.Name = "txtBoxAttachFile";
            this.txtBoxAttachFile.Size = new System.Drawing.Size(164, 20);
            this.txtBoxAttachFile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail Body :";
            // 
            // Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAttachFile);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtMailBody);
            this.Controls.Add(this.txtSubject);
            this.Name = "Send_Mail";
            this.Text = "Send_Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMailBody;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.TextBox txtBoxAttachFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}