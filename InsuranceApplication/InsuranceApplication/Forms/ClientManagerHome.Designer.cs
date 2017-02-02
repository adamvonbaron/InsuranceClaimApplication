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
            // ClientManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 404);
            this.Controls.Add(this.lblClientManagerTitle);
            this.Name = "ClientManagerHome";
            this.Text = "ClientManagerHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientManagerTitle;
    }
}