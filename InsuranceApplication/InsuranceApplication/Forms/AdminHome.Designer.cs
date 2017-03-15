namespace InsuranceApplication.Forms
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.btnCreateClientFolder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.btnMessageCenter = new System.Windows.Forms.Button();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.txtPermissionsUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnPermissionsEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEnter = new System.Windows.Forms.Button();
            this.txtDeleteUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPermissionsClear = new System.Windows.Forms.Button();
            this.btnDeleteClear = new System.Windows.Forms.Button();
            this.btnViewClear = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.txtViewUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRegisterDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterClear = new System.Windows.Forms.Button();
            this.btnRegisterEnter = new System.Windows.Forms.Button();
            this.txtRegisterPhone = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterLastname = new System.Windows.Forms.TextBox();
            this.txtRegisterFirstname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdminTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAdminTitle.Location = new System.Drawing.Point(24, 21);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(449, 25);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "Welcome to the Administrator Home Page";
            // 
            // btnCreateClientFolder
            // 
            this.btnCreateClientFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClientFolder.Location = new System.Drawing.Point(29, 314);
            this.btnCreateClientFolder.Name = "btnCreateClientFolder";
            this.btnCreateClientFolder.Size = new System.Drawing.Size(179, 62);
            this.btnCreateClientFolder.TabIndex = 3;
            this.btnCreateClientFolder.Text = "Create Client Folder";
            this.btnCreateClientFolder.UseVisualStyleBackColor = true;
            this.btnCreateClientFolder.Click += new System.EventHandler(this.btnCreateClientFolder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurUserInfo
            // 
            this.lblCurUserInfo.AutoSize = true;
            this.lblCurUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCurUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblCurUserInfo.Location = new System.Drawing.Point(26, 57);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCurUserInfo.TabIndex = 7;
            // 
            // btnMessageCenter
            // 
            this.btnMessageCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageCenter.Location = new System.Drawing.Point(249, 372);
            this.btnMessageCenter.Name = "btnMessageCenter";
            this.btnMessageCenter.Size = new System.Drawing.Size(179, 58);
            this.btnMessageCenter.TabIndex = 9;
            this.btnMessageCenter.Text = "Message Center";
            this.btnMessageCenter.UseVisualStyleBackColor = true;
            this.btnMessageCenter.Click += new System.EventHandler(this.btnMessageCenter_Click);
            // 
            // cboRank
            // 
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Location = new System.Drawing.Point(428, 163);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(121, 21);
            this.cboRank.TabIndex = 22;
            // 
            // txtPermissionsUsername
            // 
            this.txtPermissionsUsername.Location = new System.Drawing.Point(418, 134);
            this.txtPermissionsUsername.Name = "txtPermissionsUsername";
            this.txtPermissionsUsername.Size = new System.Drawing.Size(138, 20);
            this.txtPermissionsUsername.TabIndex = 21;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(323, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 18);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.Transparent;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(323, 164);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(106, 18);
            this.lblRank.TabIndex = 19;
            this.lblRank.Text = "Updated Rank:";
            // 
            // btnPermissionsEnter
            // 
            this.btnPermissionsEnter.Location = new System.Drawing.Point(326, 200);
            this.btnPermissionsEnter.Name = "btnPermissionsEnter";
            this.btnPermissionsEnter.Size = new System.Drawing.Size(75, 23);
            this.btnPermissionsEnter.TabIndex = 17;
            this.btnPermissionsEnter.Text = "Enter";
            this.btnPermissionsEnter.UseVisualStyleBackColor = true;
            this.btnPermissionsEnter.Click += new System.EventHandler(this.btnPermissionsEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(346, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADD PERMISSIONS";
            // 
            // btnDeleteEnter
            // 
            this.btnDeleteEnter.Location = new System.Drawing.Point(622, 169);
            this.btnDeleteEnter.Name = "btnDeleteEnter";
            this.btnDeleteEnter.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEnter.TabIndex = 26;
            this.btnDeleteEnter.Text = "Enter";
            this.btnDeleteEnter.UseVisualStyleBackColor = true;
            this.btnDeleteEnter.Click += new System.EventHandler(this.btnDeleteEnter_Click);
            // 
            // txtDeleteUsername
            // 
            this.txtDeleteUsername.Location = new System.Drawing.Point(709, 133);
            this.txtDeleteUsername.Name = "txtDeleteUsername";
            this.txtDeleteUsername.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteUsername.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(619, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(651, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "DELETE USER";
            // 
            // btnPermissionsClear
            // 
            this.btnPermissionsClear.Location = new System.Drawing.Point(418, 200);
            this.btnPermissionsClear.Name = "btnPermissionsClear";
            this.btnPermissionsClear.Size = new System.Drawing.Size(75, 23);
            this.btnPermissionsClear.TabIndex = 29;
            this.btnPermissionsClear.Text = "Clear";
            this.btnPermissionsClear.UseVisualStyleBackColor = true;
            this.btnPermissionsClear.Click += new System.EventHandler(this.btnPermissionsClear_Click);
            // 
            // btnDeleteClear
            // 
            this.btnDeleteClear.Location = new System.Drawing.Point(708, 169);
            this.btnDeleteClear.Name = "btnDeleteClear";
            this.btnDeleteClear.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClear.TabIndex = 30;
            this.btnDeleteClear.Text = "Clear";
            this.btnDeleteClear.UseVisualStyleBackColor = true;
            this.btnDeleteClear.Click += new System.EventHandler(this.btnDeleteClear_Click);
            // 
            // btnViewClear
            // 
            this.btnViewClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClear.Location = new System.Drawing.Point(137, 175);
            this.btnViewClear.Name = "btnViewClear";
            this.btnViewClear.Size = new System.Drawing.Size(62, 27);
            this.btnViewClear.TabIndex = 34;
            this.btnViewClear.Text = "Clear";
            this.btnViewClear.UseVisualStyleBackColor = true;
            this.btnViewClear.Click += new System.EventHandler(this.btnViewClear_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(30, 175);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(82, 27);
            this.btnViewProfile.TabIndex = 33;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // txtViewUsername
            // 
            this.txtViewUsername.Location = new System.Drawing.Point(110, 134);
            this.txtViewUsername.Name = "txtViewUsername";
            this.txtViewUsername.Size = new System.Drawing.Size(154, 20);
            this.txtViewUsername.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Username: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(56, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "VIEW/EDIT PROFILE";
            // 
            // dtpRegisterDateOfBirth
            // 
            this.dtpRegisterDateOfBirth.Location = new System.Drawing.Point(712, 383);
            this.dtpRegisterDateOfBirth.Name = "dtpRegisterDateOfBirth";
            this.dtpRegisterDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpRegisterDateOfBirth.TabIndex = 50;
            // 
            // btnRegisterClear
            // 
            this.btnRegisterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterClear.Location = new System.Drawing.Point(714, 454);
            this.btnRegisterClear.Name = "btnRegisterClear";
            this.btnRegisterClear.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterClear.TabIndex = 49;
            this.btnRegisterClear.Text = "Clear";
            this.btnRegisterClear.UseVisualStyleBackColor = true;
            this.btnRegisterClear.Click += new System.EventHandler(this.btnRegisterClear_Click);
            // 
            // btnRegisterEnter
            // 
            this.btnRegisterEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterEnter.Location = new System.Drawing.Point(622, 454);
            this.btnRegisterEnter.Name = "btnRegisterEnter";
            this.btnRegisterEnter.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterEnter.TabIndex = 48;
            this.btnRegisterEnter.Text = "Enter";
            this.btnRegisterEnter.UseVisualStyleBackColor = true;
            this.btnRegisterEnter.Click += new System.EventHandler(this.btnRegisterEnter_Click);
            // 
            // txtRegisterPhone
            // 
            this.txtRegisterPhone.Location = new System.Drawing.Point(714, 413);
            this.txtRegisterPhone.Name = "txtRegisterPhone";
            this.txtRegisterPhone.Size = new System.Drawing.Size(169, 20);
            this.txtRegisterPhone.TabIndex = 47;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(714, 357);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(169, 20);
            this.txtRegisterPassword.TabIndex = 46;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(714, 331);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(169, 20);
            this.txtRegisterUsername.TabIndex = 45;
            // 
            // txtRegisterLastname
            // 
            this.txtRegisterLastname.Location = new System.Drawing.Point(714, 305);
            this.txtRegisterLastname.Name = "txtRegisterLastname";
            this.txtRegisterLastname.Size = new System.Drawing.Size(169, 20);
            this.txtRegisterLastname.TabIndex = 44;
            // 
            // txtRegisterFirstname
            // 
            this.txtRegisterFirstname.Location = new System.Drawing.Point(714, 279);
            this.txtRegisterFirstname.Name = "txtRegisterFirstname";
            this.txtRegisterFirstname.Size = new System.Drawing.Size(169, 20);
            this.txtRegisterFirstname.TabIndex = 43;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(596, 412);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(112, 18);
            this.lblPhone.TabIndex = 42;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(596, 382);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(94, 18);
            this.lblDOB.TabIndex = 41;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(596, 356);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(596, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Username:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.White;
            this.lblLastname.Location = new System.Drawing.Point(596, 304);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(77, 18);
            this.lblLastname.TabIndex = 38;
            this.lblLastname.Text = "Lastname:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.White;
            this.lblFirstname.Location = new System.Drawing.Point(596, 278);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(78, 18);
            this.lblFirstname.TabIndex = 37;
            this.lblFirstname.Text = "Firstname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(651, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "REGISTER USER";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(955, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpRegisterDateOfBirth);
            this.Controls.Add(this.btnRegisterClear);
            this.Controls.Add(this.btnRegisterEnter);
            this.Controls.Add(this.txtRegisterPhone);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.txtRegisterLastname);
            this.Controls.Add(this.txtRegisterFirstname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnViewClear);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.txtViewUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteClear);
            this.Controls.Add(this.btnPermissionsClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteEnter);
            this.Controls.Add(this.txtDeleteUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRank);
            this.Controls.Add(this.txtPermissionsUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.btnPermissionsEnter);
            this.Controls.Add(this.btnMessageCenter);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateClientFolder);
            this.Controls.Add(this.lblAdminTitle);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Button btnCreateClientFolder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurUserInfo;
        private System.Windows.Forms.Button btnMessageCenter;
        private System.Windows.Forms.ComboBox cboRank;
        private System.Windows.Forms.TextBox txtPermissionsUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnPermissionsEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEnter;
        private System.Windows.Forms.TextBox txtDeleteUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPermissionsClear;
        private System.Windows.Forms.Button btnDeleteClear;
        private System.Windows.Forms.Button btnViewClear;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.TextBox txtViewUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRegisterDateOfBirth;
        private System.Windows.Forms.Button btnRegisterClear;
        private System.Windows.Forms.Button btnRegisterEnter;
        private System.Windows.Forms.TextBox txtRegisterPhone;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterLastname;
        private System.Windows.Forms.TextBox txtRegisterFirstname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label label7;
    }
}