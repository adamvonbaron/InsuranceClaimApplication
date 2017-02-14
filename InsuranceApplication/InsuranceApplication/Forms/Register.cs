using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Classes;
using InsuranceApplication.Forms;

namespace InsuranceApplication.Forms {
    public partial class Register : Form {
        libsql database = new libsql();
        public Register() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            database.RegisterUser(txtFirstname.Text, txtLastname.Text,
                                  txtUsername.Text, txtPassword.Text,
                                  dtpDateOfBirth.Text, txtPhone.Text);
        }
    }
}
