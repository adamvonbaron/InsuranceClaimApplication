namespace InsuranceApplication
{
    partial class formFormDemo
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
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.lblCreation = new System.Windows.Forms.Label();
            this.lblClaim = new System.Windows.Forms.Label();
            this.txtClaims = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceClaimDataSet = new InsuranceApplication.InsuranceClaimDataSet();
            this.usersTableAdapter = new InsuranceApplication.InsuranceClaimDataSetTableAdapters.usersTableAdapter();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblGetUserInfo = new System.Windows.Forms.Label();
            this.dgvViewUser = new System.Windows.Forms.DataGridView();
            this.txtGetUser = new System.Windows.Forms.TextBox();
            this.lblGetUser = new System.Windows.Forms.Label();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceClaimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 41);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(76, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(75, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(12, 135);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 8;
            this.lblRank.Text = "Rank";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(75, 135);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(149, 20);
            this.txtRank.TabIndex = 9;
            // 
            // txtCreation
            // 
            this.txtCreation.Location = new System.Drawing.Point(75, 172);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(149, 20);
            this.txtCreation.TabIndex = 10;
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Location = new System.Drawing.Point(12, 172);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(46, 13);
            this.lblCreation.TabIndex = 11;
            this.lblCreation.Text = "Creation";
            // 
            // lblClaim
            // 
            this.lblClaim.AutoSize = true;
            this.lblClaim.Location = new System.Drawing.Point(12, 207);
            this.lblClaim.Name = "lblClaim";
            this.lblClaim.Size = new System.Drawing.Size(37, 13);
            this.lblClaim.TabIndex = 12;
            this.lblClaim.Text = "Claims";
            // 
            // txtClaims
            // 
            this.txtClaims.Location = new System.Drawing.Point(76, 204);
            this.txtClaims.Name = "txtClaims";
            this.txtClaims.Size = new System.Drawing.Size(149, 20);
            this.txtClaims.TabIndex = 13;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(240, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(388, 218);
            this.dgvUsers.TabIndex = 14;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.insuranceClaimDataSet;
            // 
            // insuranceClaimDataSet
            // 
            this.insuranceClaimDataSet.DataSetName = "InsuranceClaimDataSet";
            this.insuranceClaimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(106, 233);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 230);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 17;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 266);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 16);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "Message:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 286);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "To: ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(191, 286);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "From:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(392, 286);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 13);
            this.lblSubject.TabIndex = 21;
            this.lblSubject.Text = "Subject: ";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(44, 283);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(141, 20);
            this.txtTo.TabIndex = 22;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(230, 283);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(156, 20);
            this.txtFrom.TabIndex = 23;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(447, 283);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(180, 20);
            this.txtSubject.TabIndex = 24;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 309);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(616, 227);
            this.txtMessage.TabIndex = 25;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(12, 542);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(112, 23);
            this.btnSendMessage.TabIndex = 26;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(292, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date: ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(335, 256);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(250, 20);
            this.txtDate.TabIndex = 28;
            // 
            // lblGetUserInfo
            // 
            this.lblGetUserInfo.AutoSize = true;
            this.lblGetUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetUserInfo.Location = new System.Drawing.Point(635, 13);
            this.lblGetUserInfo.Name = "lblGetUserInfo";
            this.lblGetUserInfo.Size = new System.Drawing.Size(124, 20);
            this.lblGetUserInfo.TabIndex = 29;
            this.lblGetUserInfo.Text = "Get User Info:";
            // 
            // dgvViewUser
            // 
            this.dgvViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewUser.Location = new System.Drawing.Point(639, 42);
            this.dgvViewUser.Name = "dgvViewUser";
            this.dgvViewUser.Size = new System.Drawing.Size(491, 234);
            this.dgvViewUser.TabIndex = 30;
            // 
            // txtGetUser
            // 
            this.txtGetUser.Location = new System.Drawing.Point(697, 283);
            this.txtGetUser.Name = "txtGetUser";
            this.txtGetUser.Size = new System.Drawing.Size(270, 20);
            this.txtGetUser.TabIndex = 31;
            // 
            // lblGetUser
            // 
            this.lblGetUser.AutoSize = true;
            this.lblGetUser.Location = new System.Drawing.Point(639, 285);
            this.lblGetUser.Name = "lblGetUser";
            this.lblGetUser.Size = new System.Drawing.Size(52, 13);
            this.lblGetUser.TabIndex = 32;
            this.lblGetUser.Text = "Get User:";
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Location = new System.Drawing.Point(973, 282);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(157, 23);
            this.btnGetUserInfo.TabIndex = 33;
            this.btnGetUserInfo.Text = "Get User Info";
            this.btnGetUserInfo.UseVisualStyleBackColor = true;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // formFormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 583);
            this.Controls.Add(this.btnGetUserInfo);
            this.Controls.Add(this.lblGetUser);
            this.Controls.Add(this.txtGetUser);
            this.Controls.Add(this.dgvViewUser);
            this.Controls.Add(this.lblGetUserInfo);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtClaims);
            this.Controls.Add(this.lblClaim);
            this.Controls.Add(this.lblCreation);
            this.Controls.Add(this.txtCreation);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "formFormDemo";
            this.Text = "Form Demo";
            this.Load += new System.EventHandler(this.formFormDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceClaimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.Label lblClaim;
        private System.Windows.Forms.TextBox txtClaims;
        private System.Windows.Forms.DataGridView dgvUsers;
        private InsuranceClaimDataSet insuranceClaimDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private InsuranceClaimDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblGetUserInfo;
        private System.Windows.Forms.DataGridView dgvViewUser;
        private System.Windows.Forms.TextBox txtGetUser;
        private System.Windows.Forms.Label lblGetUser;
        private System.Windows.Forms.Button btnGetUserInfo;
    }
}

