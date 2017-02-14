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
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.btnViewUserData = new System.Windows.Forms.Button();
            this.btnAddPermissions = new System.Windows.Forms.Button();
            this.btnCreateClientFolder = new System.Windows.Forms.Button();
            this.btnRegisterCMFM = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAdminTitle.Location = new System.Drawing.Point(21, 20);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(449, 25);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "Welcome to the Administrator Home Page";
            // 
            // btnViewUserData
            // 
            this.btnViewUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUserData.Location = new System.Drawing.Point(48, 83);
            this.btnViewUserData.Name = "btnViewUserData";
            this.btnViewUserData.Size = new System.Drawing.Size(179, 61);
            this.btnViewUserData.TabIndex = 1;
            this.btnViewUserData.Text = "View User Data";
            this.btnViewUserData.UseVisualStyleBackColor = true;
            this.btnViewUserData.Click += new System.EventHandler(this.btnViewUserData_Click);
            // 
            // btnAddPermissions
            // 
            this.btnAddPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPermissions.Location = new System.Drawing.Point(233, 83);
            this.btnAddPermissions.Name = "btnAddPermissions";
            this.btnAddPermissions.Size = new System.Drawing.Size(184, 61);
            this.btnAddPermissions.TabIndex = 2;
            this.btnAddPermissions.Text = "Add Permissions";
            this.btnAddPermissions.UseVisualStyleBackColor = true;
            this.btnAddPermissions.Click += new System.EventHandler(this.btnAddPermissions_Click);
            // 
            // btnCreateClientFolder
            // 
            this.btnCreateClientFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClientFolder.Location = new System.Drawing.Point(48, 150);
            this.btnCreateClientFolder.Name = "btnCreateClientFolder";
            this.btnCreateClientFolder.Size = new System.Drawing.Size(179, 62);
            this.btnCreateClientFolder.TabIndex = 3;
            this.btnCreateClientFolder.Text = "Create Client Folder";
            this.btnCreateClientFolder.UseVisualStyleBackColor = true;
            this.btnCreateClientFolder.Click += new System.EventHandler(this.btnCreateClientFolder_Click);
            // 
            // btnRegisterCMFM
            // 
            this.btnRegisterCMFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCMFM.Location = new System.Drawing.Point(233, 150);
            this.btnRegisterCMFM.Name = "btnRegisterCMFM";
            this.btnRegisterCMFM.Size = new System.Drawing.Size(184, 62);
            this.btnRegisterCMFM.TabIndex = 4;
            this.btnRegisterCMFM.Text = "Register CM/FM";
            this.btnRegisterCMFM.UseVisualStyleBackColor = true;
            this.btnRegisterCMFM.Click += new System.EventHandler(this.btnRegisterCMFM_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(48, 218);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(179, 58);
            this.btnEditProfile.TabIndex = 6;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lblCurUserInfo
            // 
            this.lblCurUserInfo.AutoSize = true;
            this.lblCurUserInfo.Location = new System.Drawing.Point(93, 332);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(35, 13);
            this.lblCurUserInfo.TabIndex = 7;
            this.lblCurUserInfo.Text = "label1";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(233, 218);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(184, 58);
            this.btnRegisterUser.TabIndex = 8;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 362);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterCMFM);
            this.Controls.Add(this.btnCreateClientFolder);
            this.Controls.Add(this.btnAddPermissions);
            this.Controls.Add(this.btnViewUserData);
            this.Controls.Add(this.lblAdminTitle);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Button btnViewUserData;
        private System.Windows.Forms.Button btnAddPermissions;
        private System.Windows.Forms.Button btnCreateClientFolder;
        private System.Windows.Forms.Button btnRegisterCMFM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label lblCurUserInfo;
        private System.Windows.Forms.Button btnRegisterUser;
    }
}