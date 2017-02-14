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
    public partial class ViewMessagesForm : Form {
        public string Username;
        libsql database = new libsql();
        public ViewMessagesForm(string username) {
            InitializeComponent();
            this.Username = username;
        }

        private void ViewMessagesForm_Load(object sender, EventArgs e) {
            try {
                DataTable messages = database.GetInboxMessages(Username);
                dgvMessages.ReadOnly = true;
                if(messages.Equals(null))
                    MessageBox.Show("No messages to display.", "Messages",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvMessages.DataSource = messages;
            } catch(Exception ex) {
                MessageBox.Show("Error retrieving messages.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
