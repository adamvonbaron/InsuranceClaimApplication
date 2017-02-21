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
    public partial class AdminCreateClientFolder : Form
    {
        public AdminCreateClientFolder()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
