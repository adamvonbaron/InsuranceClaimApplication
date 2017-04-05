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

namespace InsuranceApplication.Forms
{
    public partial class ViewClientList : Form
    {
        public ViewClientList()
        {
            InitializeComponent();

            lvClients.View = View.Details;
            DataTable clients = User.GetClients();
            lvClients.Columns.Add("firstname", 85);
            lvClients.Columns.Add("lastname", 85);
            lvClients.Columns.Add("birthday", 150);
            lvClients.Columns.Add("phonenumber", 75);
            for (int i = 0; i < clients.Rows.Count; i++)
            {
                DataRow dr = clients.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                curItem.SubItems.Add(dr[5].ToString());
                lvClients.Items.Add(curItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
