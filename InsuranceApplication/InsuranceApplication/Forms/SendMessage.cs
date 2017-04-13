using System;
using InsuranceApplication.Classes;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class SendMessage : Form
    {
        User user { get; set; }
        string To;
        string Subject;
        public SendMessage(User user, string to, string subject, bool reply)
        {
            InitializeComponent();
            Subject = "RE: " + subject;
            To = to;
            if (reply)
            {
                PopulateStuff();
                txtMessage.Focus();
            }
        }

        private void PopulateStuff()
        {
            txtTo.Text = To;
            txtSubject.Text = Subject;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show("Something went really wrong here.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
