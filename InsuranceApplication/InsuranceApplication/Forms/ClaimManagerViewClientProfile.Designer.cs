namespace InsuranceApplication.Forms
{
    partial class ClaimManagerViewClientProfile
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
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(27, 46);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(94, 20);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(128, 46);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(128, 89);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(27, 89);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(93, 20);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(27, 132);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(117, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(31, 228);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(134, 27);
            this.btnViewProfile.TabIndex = 6;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(189, 228);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 27);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ClaimManagerViewClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 392);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "ClaimManagerViewClientProfile";
            this.Text = "ClaimManagerViewClientProfile";
            this.Load += new System.EventHandler(this.ClaimManagerViewClientProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnReturn;
    }
}