namespace InsuranceApplication.Forms
{
    partial class ClaimStatus
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
            this.lvClaimStatus = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvClaimStatus
            // 
            this.lvClaimStatus.Location = new System.Drawing.Point(34, 54);
            this.lvClaimStatus.Name = "lvClaimStatus";
            this.lvClaimStatus.Size = new System.Drawing.Size(578, 266);
            this.lvClaimStatus.TabIndex = 0;
            this.lvClaimStatus.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClaimStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 383);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lvClaimStatus);
            this.Name = "ClaimStatus";
            this.Text = "ClaimStatus";
            this.Load += new System.EventHandler(this.ClaimStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvClaimStatus;
        private System.Windows.Forms.Button btnExit;
    }
}