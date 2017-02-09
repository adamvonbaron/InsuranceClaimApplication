using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class AdminAddPermissions : Form
    {
        public AdminAddPermissions()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminHome f3 = new Forms.AdminHome();
            f3.Show();
        }
    }
}
