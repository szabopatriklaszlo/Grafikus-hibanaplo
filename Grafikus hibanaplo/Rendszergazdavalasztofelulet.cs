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

        private void BT_createsysadmin_Click(object sender, EventArgs e)
        {
            Rendszergazdafiokletrehozasa createsysadminacount = new Rendszergazdafiokletrehozasa();
            this.Hide();
            createsysadminacount.Closed += (s, args) => this.Close();
            createsysadminacount.Show();
        }

        private void BT_createuser_Click(object sender, EventArgs e)
        {
            Felhasznaloifiokletrehozasa createuser = new Felhasznaloifiokletrehozasa();
            this.Hide();
            createuser.Closed += (s, args) => this.Close();
            createuser.Show();
        }

        private void BT_deletesysadmin_Click(object sender, EventArgs e)
        {
            Rendszergazdaifioktorlese deletesysadmin = new Rendszergazdaifioktorlese();
            this.Hide();
            deletesysadmin.Closed += (s, args) => this.Close();
            deletesysadmin.Show();
        }

        private void BT_deleteuser_Click(object sender, EventArgs e)
        {
            Felhasznaloifioktorlese deleteuser = new Felhasznaloifioktorlese();
            this.Hide();
            deleteuser.Closed += (s, args) => this.Close();
            deleteuser.Show();
        }

        private void BT_showactualusers_Click(object sender, EventArgs e)
        {
            Aktualisfelhasznaloifiokok actualusers = new Aktualisfelhasznaloifiokok();
            this.Hide();
            actualusers.Closed += (s, args) => this.Close();
            actualusers.Show();
        }

        private void BT_showactualsysadmins_Click(object sender, EventArgs e)
        {
            Aktualisrendszergazdaifiokok actualsysadmins = new Aktualisrendszergazdaifiokok();
            this.Hide();
            actualsysadmins.Closed += (s, args) => this.Close();
            actualsysadmins.Show();
        }

        private void BT_showreports_Click(object sender, EventArgs e)
        {
            Aktualishibakmegtekintese actualreports = new Aktualishibakmegtekintese();
            this.Hide();
            actualreports.Closed += (s, args) => this.Close();
            actualreports.Show();
        }

        private void BT_showclosedreports_Click(object sender, EventArgs e)
        {
            Lezarthibakmegtekintese closedreports = new Lezarthibakmegtekintese();
            this.Hide();
            closedreports.Closed += (s, args) => this.Close();
            closedreports.Show();
        }
    }
}
