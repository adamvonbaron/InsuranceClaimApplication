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
        DataTable messages;
        public ViewMessagesForm(string username) {
            InitializeComponent();
            this.Username = username;
        }

        private void ViewMessagesForm_Load(object sender, EventArgs e) {
            lvMessages.View = View.Details;
            DataTable messages = database.GetInboxMessages(Username);
            lvMessages.Columns.Add("From", 75);
            lvMessages.Columns.Add("Date", 125);
            lvMessages.Columns.Add("Subject", 500);
            for(int i = 0; i < messages.Rows.Count; i++) {
                DataRow dr = messages.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[1].ToString());
                curItem.SubItems.Add(dr[2].ToString());
                curItem.SubItems.Add(dr[3].ToString());
                lvMessages.Items.Add(curItem);
            }
        }

        private void lvMessages_DoubleClick(object sender, EventArgs e) {
            
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
