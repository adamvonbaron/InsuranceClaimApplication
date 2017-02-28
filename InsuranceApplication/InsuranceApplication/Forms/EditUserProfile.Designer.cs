namespace InsuranceApplication.Forms
{
    partial class EditUserProfile
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.txtUpdateLastname = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.lblUpdateDOB = new System.Windows.Forms.Label();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdateUsername = new System.Windows.Forms.Label();
            this.lblUpdateLastname = new System.Windows.Forms.Label();
            this.lblUpdateFirstname = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(92, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 240);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 34;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(214, 181);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(200, 20);
            this.txtUpdatePhone.TabIndex = 32;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(214, 112);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(200, 20);
            this.txtUpdatePassword.TabIndex = 29;
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.Location = new System.Drawing.Point(214, 79);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateUsername.TabIndex = 28;
            // 
            // txtUpdateLastname
            // 
            this.txtUpdateLastname.Location = new System.Drawing.Point(214, 43);
            this.txtUpdateLastname.Name = "txtUpdateLastname";
            this.txtUpdateLastname.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateLastname.TabIndex = 27;
            // 
            // txtUpdateFirstname
            // 
            this.txtUpdateFirstname.Location = new System.Drawing.Point(214, 11);
            this.txtUpdateFirstname.Name = "txtUpdateFirstname";
            this.txtUpdateFirstname.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateFirstname.TabIndex = 26;
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePhone.Location = new System.Drawing.Point(12, 179);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(196, 20);
            this.lblUpdatePhone.TabIndex = 24;
            this.lblUpdatePhone.Text = "Update Phone Number:";
            // 
            // lblUpdateDOB
            // 
            this.lblUpdateDOB.AutoSize = true;
            this.lblUpdateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDOB.Location = new System.Drawing.Point(12, 148);
            this.lblUpdateDOB.Name = "lblUpdateDOB";
            this.lblUpdateDOB.Size = new System.Drawing.Size(181, 20);
            this.lblUpdateDOB.TabIndex = 23;
            this.lblUpdateDOB.Text = "Update Date of Birth:";
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePassword.Location = new System.Drawing.Point(12, 110);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(155, 20);
            this.lblUpdatePassword.TabIndex = 21;
            this.lblUpdatePassword.Text = "Update Password:";
            // 
            // lblUpdateUsername
            // 
            this.lblUpdateUsername.AutoSize = true;
            this.lblUpdateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUsername.Location = new System.Drawing.Point(12, 77);
            this.lblUpdateUsername.Name = "lblUpdateUsername";
            this.lblUpdateUsername.Size = new System.Drawing.Size(160, 20);
            this.lblUpdateUsername.TabIndex = 20;
            this.lblUpdateUsername.Text = "Update Username:";
            // 
            // lblUpdateLastname
            // 
            this.lblUpdateLastname.AutoSize = true;
            this.lblUpdateLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateLastname.Location = new System.Drawing.Point(12, 41);
            this.lblUpdateLastname.Name = "lblUpdateLastname";
            this.lblUpdateLastname.Size = new System.Drawing.Size(157, 20);
            this.lblUpdateLastname.TabIndex = 19;
            this.lblUpdateLastname.Text = "Update Lastname:";
            // 
            // lblUpdateFirstname
            // 
            this.lblUpdateFirstname.AutoSize = true;
            this.lblUpdateFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFirstname.Location = new System.Drawing.Point(12, 9);
            this.lblUpdateFirstname.Name = "lblUpdateFirstname";
            this.lblUpdateFirstname.Size = new System.Drawing.Size(158, 20);
            this.lblUpdateFirstname.TabIndex = 18;
            this.lblUpdateFirstname.Text = "Update Firstname:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(214, 147);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 36;
            // 
            // EditUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 275);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtUpdatePhone);
            this.Controls.Add(this.txtUpdatePassword);
            this.Controls.Add(this.txtUpdateUsername);
            this.Controls.Add(this.txtUpdateLastname);
            this.Controls.Add(this.txtUpdateFirstname);
            this.Controls.Add(this.lblUpdatePhone);
            this.Controls.Add(this.lblUpdateDOB);
            this.Controls.Add(this.lblUpdatePassword);
            this.Controls.Add(this.lblUpdateUsername);
            this.Controls.Add(this.lblUpdateLastname);
            this.Controls.Add(this.lblUpdateFirstname);
            this.Name = "EditUserProfile";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.TextBox txtUpdateLastname;
        private System.Windows.Forms.TextBox txtUpdateFirstname;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.Label lblUpdateDOB;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdateUsername;
        private System.Windows.Forms.Label lblUpdateLastname;
        private System.Windows.Forms.Label lblUpdateFirstname;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}