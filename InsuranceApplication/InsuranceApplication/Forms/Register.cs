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
            //string[] lines = {txtFirstname.Text+" "+txtLastname.Text};
            //System.IO.File.WriteAllLines(@"H:\SE361\Register.txt", lines);

            ////Open File
            //TextWriter tw = new StreamWriter(@"H:\SE361\Register.txt");

            ////Write to file
            //tw.WriteLine("First Name: "+txtFirstname.Text+" Last Name: "+txtLastname.Text+" Username: "+txtUsername.Text+" Password: "+txtPassword.Text+
            //    " Email: "+txtEmail.Text+" Date of Birth: "+txtDOB.Text+" Phone: "+txtPhone.Text+" Address: "+txtAddress.Text);

            ////Close File
            //tw.Close();
            using (StreamWriter w = File.AppendText(@"H:\SE361\Register.txt"))
            {
                w.WriteLine("First Name: " + txtFirstname.Text + " Last Name: " + txtLastname.Text + " Username: " + txtUsername.Text + " Password: " + txtPassword.Text +
                   " Email: "+txtEmail.Text+" Date of Birth: "+txtDOB.Text+" Phone: "+txtPhone.Text+" Address: "+txtAddress.Text);
                w.Flush();
            }
        }
    }
}
