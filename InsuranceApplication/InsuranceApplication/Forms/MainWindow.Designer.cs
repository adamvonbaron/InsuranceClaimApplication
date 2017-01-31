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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnClientManager = new System.Windows.Forms.Button();
            this.btnFinanceManager = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTestDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Insurance Claim Management System";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(42, 120);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(182, 20);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Select the User Type:";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.Location = new System.Drawing.Point(42, 239);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(120, 46);
            this.btnAdministrator.TabIndex = 2;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnClientManager
            // 
            this.btnClientManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientManager.Location = new System.Drawing.Point(169, 239);
            this.btnClientManager.Name = "btnClientManager";
            this.btnClientManager.Size = new System.Drawing.Size(120, 46);
            this.btnClientManager.TabIndex = 3;
            this.btnClientManager.Text = "Client Manager";
            this.btnClientManager.UseVisualStyleBackColor = true;
            // 
            // btnFinanceManager
            // 
            this.btnFinanceManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceManager.Location = new System.Drawing.Point(295, 239);
            this.btnFinanceManager.Name = "btnFinanceManager";
            this.btnFinanceManager.Size = new System.Drawing.Size(120, 46);
            this.btnFinanceManager.TabIndex = 4;
            this.btnFinanceManager.Text = "Finance Manager";
            this.btnFinanceManager.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(421, 239);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(120, 46);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(457, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTestDB
            // 
            this.btnTestDB.Location = new System.Drawing.Point(376, 351);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(75, 23);
            this.btnTestDB.TabIndex = 7;
            this.btnTestDB.Text = "test DB";
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // formInsuranceClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 399);
            this.Controls.Add(this.btnTestDB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnFinanceManager);
            this.Controls.Add(this.btnClientManager);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "formInsuranceClaim";
            this.Text = "Insurance Claim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnClientManager;
        private System.Windows.Forms.Button btnFinanceManager;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTestDB;
    }
}

