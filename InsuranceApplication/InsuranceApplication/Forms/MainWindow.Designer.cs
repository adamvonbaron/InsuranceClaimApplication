namespace InsuranceApplication
{
    partial class formInsuranceClaim
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Insurance Claim Management System";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(149, 128);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 24);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(149, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(267, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(267, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(142, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(299, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(394, 347);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(141, 23);
            this.btnForgotPassword.TabIndex = 7;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(36, 347);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(394, 318);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(141, 23);
            this.btnDriver.TabIndex = 9;
            this.btnDriver.Text = "Run Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // formInsuranceClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 386);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "formInsuranceClaim";
            this.Text = "Insurance Claim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDriver;
    }
}

