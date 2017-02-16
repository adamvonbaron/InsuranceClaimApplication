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
using InsuranceApplication.Forms;

namespace InsuranceApplication.Forms {
    public partial class SendMessage : Form {
        libsql database = new libsql();
        string Username;
        public SendMessage(string username) {
            InitializeComponent();
            this.Username = username;
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (database.SendMessage(txtTo.Text, Username, DateTime.Now.ToString(),
                                 txtSubject.Text, txtMessage.Text))
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
