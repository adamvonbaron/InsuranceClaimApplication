﻿using System;
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
    public partial class MessageCenter : Form
    {
        public string Username;
        public MessageCenter(string username) {
            InitializeComponent();
            this.Username = username;
        }

        private void btnSendMessage_Click(object sender, EventArgs e) {
            SendMessage sm = new SendMessage(Username);
            sm.ShowDialog();
        }
    }
}
