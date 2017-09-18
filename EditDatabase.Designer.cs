namespace Instant_Help
{
    partial class EditDatabase
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
            this.btnSearchDataBase = new System.Windows.Forms.Button();
            this.txtSearchDatabase = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditDatabaseBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDataBase
            // 
            this.btnSearchDataBase.Location = new System.Drawing.Point(272, 39);
            this.btnSearchDataBase.Name = "btnSearchDataBase";
            this.btnSearchDataBase.Size = new System.Drawing.Size(159, 23);
            this.btnSearchDataBase.TabIndex = 0;
            this.btnSearchDataBase.Text = "Search Database";
            this.btnSearchDataBase.UseVisualStyleBackColor = true;
            this.btnSearchDataBase.Click += new System.EventHandler(this.btnSearchDataBase_Click);
            // 
            // txtSearchDatabase
            // 
            this.txtSearchDatabase.Location = new System.Drawing.Point(47, 42);
            this.txtSearchDatabase.Name = "txtSearchDatabase";
            this.txtSearchDatabase.Size = new System.Drawing.Size(163, 20);
            this.txtSearchDatabase.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 342);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnEditDatabaseBack
            // 
            this.btnEditDatabaseBack.Location = new System.Drawing.Point(27, 475);
            this.btnEditDatabaseBack.Name = "btnEditDatabaseBack";
            this.btnEditDatabaseBack.Size = new System.Drawing.Size(75, 23);
            this.btnEditDatabaseBack.TabIndex = 3;
            this.btnEditDatabaseBack.Text = "Back";
            this.btnEditDatabaseBack.UseVisualStyleBackColor = true;
            this.btnEditDatabaseBack.Click += new System.EventHandler(this.btnEditDatabaseBack_Click);
            // 
            // EditDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 524);
            this.Controls.Add(this.btnEditDatabaseBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchDatabase);
            this.Controls.Add(this.btnSearchDataBase);
            this.Name = "EditDatabase";
            this.Text = "EditDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDataBase;
        private System.Windows.Forms.TextBox txtSearchDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditDatabaseBack;
    }
}