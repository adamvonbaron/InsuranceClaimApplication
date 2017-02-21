namespace InsuranceApplication.Forms
{
    partial class ViewUserProfile
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNumOfClaims = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(12, 119);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 25);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 16);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 5;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(12, 57);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(63, 16);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 73);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(101, 16);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblNumOfClaims
            // 
            this.lblNumOfClaims.AutoSize = true;
            this.lblNumOfClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfClaims.Location = new System.Drawing.Point(12, 89);
            this.lblNumOfClaims.Name = "lblNumOfClaims";
            this.lblNumOfClaims.Size = new System.Drawing.Size(76, 16);
            this.lblNumOfClaims.TabIndex = 8;
            this.lblNumOfClaims.Text = "# of Claims:";
            // 
            // ViewUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 152);
            this.Controls.Add(this.lblNumOfClaims);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.lblFirstName);
            this.Name = "ViewUserProfile";
            this.Text = "ViewUserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNumOfClaims;
    }
}