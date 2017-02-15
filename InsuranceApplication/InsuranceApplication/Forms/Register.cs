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

namespace InsuranceApplication.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Classes.libsql.RegisterUser(txtFirstname.Text, txtLastname.Text, txtUsername.Text, txtPassword.Text, txtDOB.Text, txtPhone.Text);

            using (StreamWriter w = File.AppendText(@"H:\SE361\Register.txt"))
            {
                w.WriteLine("First Name: " + txtFirstname.Text + " Last Name: " + txtLastname.Text + " Username: " + txtUsername.Text + " Password: " + txtPassword.Text +
                   " Email: "+txtEmail.Text+" Date of Birth: "+txtDOB.Text+" Phone: "+txtPhone.Text+" Address: "+txtAddress.Text);
                w.Flush();
            }
        }
    }
}
