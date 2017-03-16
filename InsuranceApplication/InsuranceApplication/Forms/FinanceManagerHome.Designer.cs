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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewClear = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.txtViewUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinanceManagerHome
            // 
            this.lblFinanceManagerHome.AutoSize = true;
            this.lblFinanceManagerHome.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceManagerHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceManagerHome.Location = new System.Drawing.Point(21, 20);
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
            this.btnViewClientList.Click += new System.EventHandler(this.btnViewClientList_Click);
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
            this.lblCurUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCurUserInfo.ForeColor = System.Drawing.Color.Black;
            this.lblCurUserInfo.Location = new System.Drawing.Point(22, 59);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCurUserInfo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(474, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "VIEW/EDIT PROFILE";
            // 
            // btnViewClear
            // 
            this.btnViewClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClear.Location = new System.Drawing.Point(555, 149);
            this.btnViewClear.Name = "btnViewClear";
            this.btnViewClear.Size = new System.Drawing.Size(62, 27);
            this.btnViewClear.TabIndex = 39;
            this.btnViewClear.Text = "Clear";
            this.btnViewClear.UseVisualStyleBackColor = true;
            this.btnViewClear.Click += new System.EventHandler(this.btnViewClear_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(448, 149);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(82, 27);
            this.btnViewProfile.TabIndex = 38;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // txtViewUsername
            // 
            this.txtViewUsername.Location = new System.Drawing.Point(528, 108);
            this.txtViewUsername.Name = "txtViewUsername";
            this.txtViewUsername.Size = new System.Drawing.Size(154, 20);
            this.txtViewUsername.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(445, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Username: ";
            // 
            // FinanceManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnViewClear);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.txtViewUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
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
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurUserInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewClear;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.TextBox txtViewUsername;
        private System.Windows.Forms.Label label4;
    }
}