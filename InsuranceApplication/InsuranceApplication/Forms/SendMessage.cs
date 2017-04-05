using System;
using InsuranceApplication.Classes;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class SendMessage : Form
    {
        User user { get; set; }
        public SendMessage(User user)
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
