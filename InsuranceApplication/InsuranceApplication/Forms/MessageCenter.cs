using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class MessageCenter : Form
    {
        Admin admin;
        public MessageCenter(Admin admin) {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnSendMessage_Click(object sender, EventArgs e) {
            SendMessage sm = new SendMessage(admin);
            sm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
