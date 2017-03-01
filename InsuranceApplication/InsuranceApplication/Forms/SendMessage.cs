using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms {
    public partial class SendMessage : Form {
        User user;
        public SendMessage(User user) {
            InitializeComponent();
            this.user = user;
        }

        private void btnSend_Click(object sender, EventArgs e) {
            Classes.Message message = new Classes.Message
            {
                To = txtTo.Text,
                From = user.UserName,
                Date = DateTime.Now.ToString(),
                Subject = txtSubject.Text,
                Content = txtMessage.Text
            };
            if (User.SendMessage(message))
            {
                MessageBox.Show("Message sent successfully.", "Message", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnDraft_Click(object sender, EventArgs e) {

        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
