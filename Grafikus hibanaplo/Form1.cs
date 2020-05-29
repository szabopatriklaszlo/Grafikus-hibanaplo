﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Grafikus_hibanaplo
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void BT_sysadmin_Click(object sender, EventArgs e)
        {
            Rendszergazdalogin sysadminlogin = new Rendszergazdalogin();
            this.Hide();
            sysadminlogin.Closed += (s, args) => this.Close();
            sysadminlogin.Show();
        }

        private void BT_user_Click(object sender, EventArgs e)
        {
            Form1 userlogin = new Form1();
            this.Hide();
            userlogin.Closed += (s, args) => this.Close();
            userlogin.Show();
        }
    }
}
