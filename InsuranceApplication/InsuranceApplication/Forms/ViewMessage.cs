using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class ViewMessage : Form
    {
        User pubUser;
        public ViewMessage(User user, string from, string subject, string date, string message)
        {
            InitializeComponent();
            lblFromDisplay.Text = from;
            lblSubjectDisplay.Text = subject;
            lblDateDisplay.Text = date;
            txtMessage.Text = message;
            pubUser = user;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            SendMessage sendmessage = new SendMessage(pubUser, lblFromDisplay.Text, lblSubjectDisplay.Text, true);
            sendmessage.ShowDialog();
        }
    }
}
