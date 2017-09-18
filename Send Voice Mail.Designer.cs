namespace Instant_Help
{
    partial class Send_Voice_Mail
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
            this.components = new System.ComponentModel.Container();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnPlayRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.txtTimerBox = new System.Windows.Forms.TextBox();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(31, 82);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(129, 23);
            this.btnStartRecording.TabIndex = 0;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnPlayRecording
            // 
            this.btnPlayRecording.Location = new System.Drawing.Point(31, 253);
            this.btnPlayRecording.Name = "btnPlayRecording";
            this.btnPlayRecording.Size = new System.Drawing.Size(129, 23);
            this.btnPlayRecording.TabIndex = 1;
            this.btnPlayRecording.Text = "Play Recording";
            this.btnPlayRecording.UseVisualStyleBackColor = true;
            this.btnPlayRecording.Click += new System.EventHandler(this.btnPlayRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(121, 161);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(116, 23);
            this.btnStopRecording.TabIndex = 2;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // txtTimerBox
            // 
            this.txtTimerBox.Enabled = false;
            this.txtTimerBox.Location = new System.Drawing.Point(297, 82);
            this.txtTimerBox.Name = "txtTimerBox";
            this.txtTimerBox.Size = new System.Drawing.Size(62, 20);
            this.txtTimerBox.TabIndex = 3;
            // 
            // sourceList
            // 
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.sourceList.Location = new System.Drawing.Point(377, 54);
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(232, 97);
            this.sourceList.TabIndex = 4;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Available Input Media";
            this.columnHeader1.Width = 260;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Left :";
            // 
            // Send_Voice_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceList);
            this.Controls.Add(this.txtTimerBox);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnPlayRecording);
            this.Controls.Add(this.btnStartRecording);
            this.Name = "Send_Voice_Mail";
            this.Text = "Send_Voice_Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Send_Voice_Mail_FormClosing);
            this.Load += new System.EventHandler(this.Send_Voice_Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnPlayRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.TextBox txtTimerBox;
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}