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
        public Register() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            Client client = new Client(new UserData
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Birthday = dtpDateOfBirth.Value.ToString(),
                Phonenumber = txtPhone.Text,
                Type = UserType.Client
            });
            if(Admin.RegisterUser(client))
                MessageBox.Show("Registered user successfully.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error registering user.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
