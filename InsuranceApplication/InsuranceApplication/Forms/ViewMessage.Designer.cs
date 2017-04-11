namespace InsuranceApplication.Forms
{
    partial class ViewMessage
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFromDisplay = new System.Windows.Forms.Label();
            this.lblSubjectDisplay = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From: ";
            // 
            // lblFromDisplay
            // 
            this.lblFromDisplay.AutoSize = true;
            this.lblFromDisplay.Location = new System.Drawing.Point(67, 9);
            this.lblFromDisplay.Name = "lblFromDisplay";
            this.lblFromDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblFromDisplay.TabIndex = 1;
            this.lblFromDisplay.Text = "label2";
            // 
            // lblSubjectDisplay
            // 
            this.lblSubjectDisplay.AutoSize = true;
            this.lblSubjectDisplay.Location = new System.Drawing.Point(67, 22);
            this.lblSubjectDisplay.Name = "lblSubjectDisplay";
            this.lblSubjectDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblSubjectDisplay.TabIndex = 3;
            this.lblSubjectDisplay.Text = "label2";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 22);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject: ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 51);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(415, 320);
            this.txtMessage.TabIndex = 4;
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(15, 377);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(75, 23);
            this.btnReply.TabIndex = 5;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.AutoSize = true;
            this.lblDateDisplay.Location = new System.Drawing.Point(67, 35);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblDateDisplay.TabIndex = 7;
            this.lblDateDisplay.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date: ";
            // 
            // ViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 410);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblSubjectDisplay);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblFromDisplay);
            this.Controls.Add(this.lblFrom);
            this.Name = "ViewMessage";
            this.Text = "ViewMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFromDisplay;
        private System.Windows.Forms.Label lblSubjectDisplay;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label lblDateDisplay;
        private System.Windows.Forms.Label lblDate;
    }
}