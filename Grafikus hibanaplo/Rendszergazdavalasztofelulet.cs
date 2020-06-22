using System;
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
    public partial class Rendszergazdavalasztofelulet : Form
    {
        public Rendszergazdavalasztofelulet()
        {
            InitializeComponent();
        }


        private void BT_createuser_Click(object sender, EventArgs e)
        {
            Fiokmuveletek deleteuser = new Fiokmuveletek("createuser");
            this.Hide();
            deleteuser.Closed += (s, args) => this.Close();
            deleteuser.Show();
        }

        private void BT_deleteuser_Click(object sender, EventArgs e)
        {
            Fiokmuveletek deleteuser = new Fiokmuveletek("deleteuser");
            this.Hide();
            deleteuser.Closed += (s, args) => this.Close();
            deleteuser.Show();
        }

        private void BT_showactualusers_Click(object sender, EventArgs e)
        {
            Aktualisfelhasznalok actualsysadmins = new Aktualisfelhasznalok("user");
            this.Hide();
            actualsysadmins.Closed += (s, args) => this.Close();
            actualsysadmins.Show();
        }

        private void BT_showactualsysadmins_Click(object sender, EventArgs e)
        {
            Aktualisfelhasznalok actualsysadmins = new Aktualisfelhasznalok("sysadmin");
            this.Hide();
            actualsysadmins.Closed += (s, args) => this.Close();
            actualsysadmins.Show();
        }

        private void BT_showreports_Click(object sender, EventArgs e)
        {
            Hibakkezelese actualreports = new Hibakkezelese("edit");
            this.Hide();
            actualreports.Closed += (s, args) => this.Close();
            actualreports.Show();
        }

        private void BT_showclosedreports_Click(object sender, EventArgs e)
        {
            Hibakkezelese actualreports = new Hibakkezelese("old");
            this.Hide();
            actualreports.Closed += (s, args) => this.Close();
            actualreports.Show();
        }

        private void BT_emailsystem_Click_1(object sender, EventArgs e)
        {
            Emailmuvelet emailsettings = new Emailmuvelet();
            this.Hide();
            emailsettings.Closed += (s, args) => this.Close();
            emailsettings.Show();
        }
    }
}
