using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Grafikus_hibanaplo
{
    public partial class Felhasznaloifiokletrehozasa : Form
    {
        public Felhasznaloifiokletrehozasa()
        {
            InitializeComponent();
        }

        private void BT_back_Click(object sender, EventArgs e)
        {
            Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
            this.Hide();
            chwindow.Closed += (s, args) => this.Close();
            chwindow.Show();
        }

        private void BT_create_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sqlcmd = myConn.CreateCommand();
                sqlcmd.CommandType = CommandType.Text;
                string command = "INSERT INTO users(username,password) VALUES('" + TB_username.Text + "','" + TB_password.Text + "')";
                sqlcmd.CommandText = command;
                sqlcmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("A művelet végrehajtásra került! Kérjük ellenőrízze az eredményességét az aktuális felhasználói fiókok fül alatt.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
            }
        }
    }
}
