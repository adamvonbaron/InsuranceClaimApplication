namespace InsuranceApplication.Forms
{
    partial class SendMessage
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
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCompose = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To: ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 42);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject: ";
            // 
            // lblCompose
            // 
            this.lblCompose.AutoSize = true;
            this.lblCompose.Location = new System.Drawing.Point(12, 75);
            this.lblCompose.Name = "lblCompose";
            this.lblCompose.Size = new System.Drawing.Size(57, 13);
            this.lblCompose.TabIndex = 2;
            this.lblCompose.Text = "Compose: ";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(67, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(67, 39);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 91);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(431, 359);
            this.txtMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 470);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.Location = new System.Drawing.Point(93, 470);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(75, 23);
            this.btnDraft.TabIndex = 7;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(174, 470);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 505);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnDraft);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblCompose);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblCompose;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button Exit;
    }
}