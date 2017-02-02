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
            this.lblFinanceManagerHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinanceManagerHome
            // 
            this.lblFinanceManagerHome.AutoSize = true;
            this.lblFinanceManagerHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceManagerHome.Location = new System.Drawing.Point(35, 31);
            this.lblFinanceManagerHome.Name = "lblFinanceManagerHome";
            this.lblFinanceManagerHome.Size = new System.Drawing.Size(442, 24);
            this.lblFinanceManagerHome.TabIndex = 0;
            this.lblFinanceManagerHome.Text = "Welcome to the Finance Manager Home Page";
            // 
            // FinanceManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 381);
            this.Controls.Add(this.lblFinanceManagerHome);
            this.Name = "FinanceManagerHome";
            this.Text = "FinanceManagerHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinanceManagerHome;
    }
}