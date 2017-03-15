namespace InsuranceApplication.Forms
{
    partial class ClientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            this.lblClientHome = new System.Windows.Forms.Label();
            this.btnApplyForClaim = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientHome
            // 
            this.lblClientHome.AutoSize = true;
            this.lblClientHome.BackColor = System.Drawing.Color.Transparent;
            this.lblClientHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientHome.Location = new System.Drawing.Point(12, 9);
            this.lblClientHome.Name = "lblClientHome";
            this.lblClientHome.Size = new System.Drawing.Size(331, 24);
            this.lblClientHome.TabIndex = 0;
            this.lblClientHome.Text = "Welcome to the Client Home Page";
            // 
            // btnApplyForClaim
            // 
            this.btnApplyForClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyForClaim.Location = new System.Drawing.Point(55, 76);
            this.btnApplyForClaim.Name = "btnApplyForClaim";
            this.btnApplyForClaim.Size = new System.Drawing.Size(176, 77);
            this.btnApplyForClaim.TabIndex = 1;
            this.btnApplyForClaim.Text = "Apply for Claim";
            this.btnApplyForClaim.UseVisualStyleBackColor = true;
            this.btnApplyForClaim.Click += new System.EventHandler(this.btnApplyForClaim_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMessages.Location = new System.Drawing.Point(55, 159);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(176, 75);
            this.btnViewMessages.TabIndex = 2;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(237, 76);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(177, 77);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload Scanned Documents";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(55, 240);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(359, 34);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.Location = new System.Drawing.Point(236, 159);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(178, 75);
            this.btnViewStatus.TabIndex = 5;
            this.btnViewStatus.Text = "View Current Status";
            this.btnViewStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurUserInfo
            // 
            this.lblCurUserInfo.AutoSize = true;
            this.lblCurUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCurUserInfo.Location = new System.Drawing.Point(13, 43);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCurUserInfo.TabIndex = 7;
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 444);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnApplyForClaim);
            this.Controls.Add(this.lblClientHome);
            this.Name = "ClientHome";
            this.Text = "ClientHome";
            this.Load += new System.EventHandler(this.ClientHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientHome;
        private System.Windows.Forms.Button btnApplyForClaim;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurUserInfo;
    }
}