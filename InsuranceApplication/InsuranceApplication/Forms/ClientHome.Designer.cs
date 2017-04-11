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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblCompose = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvManagers = new System.Windows.Forms.ListView();
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
            this.btnApplyForClaim.Location = new System.Drawing.Point(684, 554);
            this.btnApplyForClaim.Name = "btnApplyForClaim";
            this.btnApplyForClaim.Size = new System.Drawing.Size(151, 40);
            this.btnApplyForClaim.TabIndex = 1;
            this.btnApplyForClaim.Text = "Apply for Claim";
            this.btnApplyForClaim.UseVisualStyleBackColor = true;
            this.btnApplyForClaim.Click += new System.EventHandler(this.btnApplyForClaim_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(497, 550);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(161, 48);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload Scanned Documents";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(528, 621);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(114, 34);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.Location = new System.Drawing.Point(684, 619);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(156, 39);
            this.btnViewStatus.TabIndex = 5;
            this.btnViewStatus.Text = "View Current Status";
            this.btnViewStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 653);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(127, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "VIEW MESSAGES";
            // 
            // lvMessages
            // 
            this.lvMessages.Location = new System.Drawing.Point(33, 96);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(383, 200);
            this.lvMessages.TabIndex = 54;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(560, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "SEND MESSAGES";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(512, 486);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 70;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(512, 207);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(309, 253);
            this.txtMessage.TabIndex = 69;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(564, 151);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 20);
            this.txtSubject.TabIndex = 68;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(564, 118);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 67;
            // 
            // lblCompose
            // 
            this.lblCompose.AutoSize = true;
            this.lblCompose.BackColor = System.Drawing.Color.Transparent;
            this.lblCompose.ForeColor = System.Drawing.Color.Black;
            this.lblCompose.Location = new System.Drawing.Point(509, 182);
            this.lblCompose.Name = "lblCompose";
            this.lblCompose.Size = new System.Drawing.Size(57, 13);
            this.lblCompose.TabIndex = 66;
            this.lblCompose.Text = "Compose: ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.ForeColor = System.Drawing.Color.Black;
            this.lblSubject.Location = new System.Drawing.Point(509, 154);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 13);
            this.lblSubject.TabIndex = 65;
            this.lblSubject.Text = "Subject: ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(509, 121);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 64;
            this.lblTo.Text = "To: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "VIEW MANAGEMENT";
            // 
            // lvManagers
            // 
            this.lvManagers.Location = new System.Drawing.Point(16, 371);
            this.lvManagers.Name = "lvManagers";
            this.lvManagers.Size = new System.Drawing.Size(433, 257);
            this.lvManagers.TabIndex = 84;
            this.lvManagers.UseCompatibleStateImageBehavior = false;
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvManagers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblCompose);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnUpload);
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
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurUserInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblCompose;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvManagers;
    }
}