namespace InsuranceApplication.Forms
{
    partial class FinanceManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceManagerHome));
            this.lblFinanceManagerHome = new System.Windows.Forms.Label();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnViewClientList = new System.Windows.Forms.Button();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewClientProfile = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinanceManagerHome
            // 
            this.lblFinanceManagerHome.AutoSize = true;
            this.lblFinanceManagerHome.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceManagerHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceManagerHome.Location = new System.Drawing.Point(35, 31);
            this.lblFinanceManagerHome.Name = "lblFinanceManagerHome";
            this.lblFinanceManagerHome.Size = new System.Drawing.Size(442, 24);
            this.lblFinanceManagerHome.TabIndex = 0;
            this.lblFinanceManagerHome.Text = "Welcome to the Finance Manager Home Page";
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMessages.Location = new System.Drawing.Point(94, 87);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(167, 58);
            this.btnViewMessages.TabIndex = 1;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            // 
            // btnViewClientList
            // 
            this.btnViewClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClientList.Location = new System.Drawing.Point(94, 151);
            this.btnViewClientList.Name = "btnViewClientList";
            this.btnViewClientList.Size = new System.Drawing.Size(167, 58);
            this.btnViewClientList.TabIndex = 2;
            this.btnViewClientList.Text = "View Client List";
            this.btnViewClientList.UseVisualStyleBackColor = true;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(94, 215);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(167, 56);
            this.btnEstimate.TabIndex = 3;
            this.btnEstimate.Text = "Estimate Amount";
            this.btnEstimate.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(267, 87);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(153, 58);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnViewClientProfile
            // 
            this.btnViewClientProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClientProfile.Location = new System.Drawing.Point(267, 151);
            this.btnViewClientProfile.Name = "btnViewClientProfile";
            this.btnViewClientProfile.Size = new System.Drawing.Size(153, 58);
            this.btnViewClientProfile.TabIndex = 5;
            this.btnViewClientProfile.Text = "View Client Profile";
            this.btnViewClientProfile.UseVisualStyleBackColor = true;
            this.btnViewClientProfile.Click += new System.EventHandler(this.btnViewClientProfile_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(267, 215);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(153, 56);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer Details to Client";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurUserInfo
            // 
            this.lblCurUserInfo.AutoSize = true;
            this.lblCurUserInfo.Location = new System.Drawing.Point(120, 360);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCurUserInfo.TabIndex = 8;
            // 
            // FinanceManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(508, 390);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnViewClientProfile);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.btnViewClientList);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.lblFinanceManagerHome);
            this.Name = "FinanceManagerHome";
            this.Text = "FinanceManagerHome";
            this.Load += new System.EventHandler(this.FinanceManagerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinanceManagerHome;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnViewClientList;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnViewClientProfile;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurUserInfo;
    }
}