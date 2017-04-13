using System;
using InsuranceApplication.Classes;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class SendMessage : Form
    {
        string username;
        string To;
        string Subject;
        public SendMessage(String username, string to, string subject, bool reply)
        {
            this.username = username;
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
                    From = username,
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
            catch (NullReferenceException err)
            {
                MessageBox.Show(err.Message + "\n" + err.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
