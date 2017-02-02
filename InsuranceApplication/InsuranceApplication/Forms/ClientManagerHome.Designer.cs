namespace InsuranceApplication.Forms
{
    partial class ClientManagerHome
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
            this.lblClientManagerTitle = new System.Windows.Forms.Label();
            this.btnViewClientList = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewClientProfile = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientManagerTitle
            // 
            this.lblClientManagerTitle.AutoSize = true;
            this.lblClientManagerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientManagerTitle.Location = new System.Drawing.Point(40, 35);
            this.lblClientManagerTitle.Name = "lblClientManagerTitle";
            this.lblClientManagerTitle.Size = new System.Drawing.Size(419, 24);
            this.lblClientManagerTitle.TabIndex = 0;
            this.lblClientManagerTitle.Text = "Welcome to the Client Manager Home Page";
            // 
            // btnViewClientList
            // 
            this.btnViewClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClientList.Location = new System.Drawing.Point(44, 88);
            this.btnViewClientList.Name = "btnViewClientList";
            this.btnViewClientList.Size = new System.Drawing.Size(161, 53);
            this.btnViewClientList.TabIndex = 1;
            this.btnViewClientList.Text = "View Client List";
            this.btnViewClientList.UseVisualStyleBackColor = true;
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMessages.Location = new System.Drawing.Point(44, 163);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(161, 52);
            this.btnViewMessages.TabIndex = 2;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(247, 158);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(173, 57);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download Scanned Documents";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(247, 88);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(173, 53);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnViewClientProfile
            // 
            this.btnViewClientProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClientProfile.Location = new System.Drawing.Point(44, 241);
            this.btnViewClientProfile.Name = "btnViewClientProfile";
            this.btnViewClientProfile.Size = new System.Drawing.Size(161, 60);
            this.btnViewClientProfile.TabIndex = 5;
            this.btnViewClientProfile.Text = "View Client Profile";
            this.btnViewClientProfile.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(247, 241);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(173, 60);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer File to FM";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClientManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnViewClientProfile);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnViewClientList);
            this.Controls.Add(this.lblClientManagerTitle);
            this.Name = "ClientManagerHome";
            this.Text = "ClientManagerHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientManagerTitle;
        private System.Windows.Forms.Button btnViewClientList;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnViewClientProfile;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
    }
}