namespace Instant_Help
{
    partial class Login_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblRegisterHere = new System.Windows.Forms.LinkLabel();
            this.lblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.txtBoxLgUserName = new System.Windows.Forms.TextBox();
            this.txtBoxLgPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(150, 181);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRegisterHere
            // 
            this.lblRegisterHere.AutoSize = true;
            this.lblRegisterHere.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHere.LinkColor = System.Drawing.Color.Transparent;
            this.lblRegisterHere.Location = new System.Drawing.Point(266, 272);
            this.lblRegisterHere.Name = "lblRegisterHere";
            this.lblRegisterHere.Size = new System.Drawing.Size(84, 13);
            this.lblRegisterHere.TabIndex = 3;
            this.lblRegisterHere.TabStop = true;
            this.lblRegisterHere.Text = "Register Here ?";
            this.lblRegisterHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.LinkColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Location = new System.Drawing.Point(12, 272);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(102, 13);
            this.lblForgetPassword.TabIndex = 4;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "Forget Password ?";
            // 
            // txtBoxLgUserName
            // 
            this.txtBoxLgUserName.Location = new System.Drawing.Point(131, 27);
            this.txtBoxLgUserName.Name = "txtBoxLgUserName";
            this.txtBoxLgUserName.Size = new System.Drawing.Size(219, 20);
            this.txtBoxLgUserName.TabIndex = 5;
            // 
            // txtBoxLgPassword
            // 
            this.txtBoxLgPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLgPassword.Location = new System.Drawing.Point(131, 96);
            this.txtBoxLgPassword.Name = "txtBoxLgPassword";
            this.txtBoxLgPassword.Size = new System.Drawing.Size(219, 22);
            this.txtBoxLgPassword.TabIndex = 6;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(381, 504);
            this.Controls.Add(this.txtBoxLgPassword);
            this.Controls.Add(this.txtBoxLgUserName);
            this.Controls.Add(this.lblForgetPassword);
            this.Controls.Add(this.lblRegisterHere);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login_Page";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel lblRegisterHere;
        private System.Windows.Forms.LinkLabel lblForgetPassword;
        private System.Windows.Forms.TextBox txtBoxLgUserName;
        private System.Windows.Forms.TextBox txtBoxLgPassword;
    }
}

