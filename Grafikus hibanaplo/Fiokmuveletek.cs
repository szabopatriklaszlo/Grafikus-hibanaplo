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
    public partial class Fiokmuveletek : Form
    {
        public Fiokmuveletek(string type)
        {
            InitializeComponent();
            if (type == "createuser")
            {
                this.Text = "Felhasználói fiók létrehozása";
                LBL_warning1.Visible = false;
                LBL_warning2.Visible = false;
                LBL_message.Text = "Írja be a kívánt felhasználónevet valamint jelszavat és kattintson a létrehozás gombra.";
                BT_delete.Text = "Létrehozás";
            }
            else if(type == "deleteuser")
            {
                this.Text = "Felhasználói fiók törlése";
                LBL_warning1.Visible = true;
                LBL_warning2.Visible = true;
                LBL_message.Text = "Írja be a kívánt felhasználónevet valamint jelszavat és kattintson a törlés gombra.";
                BT_delete.Text = "Törlés";
            }
            else if (type == "createsysadmin")
            {
                this.Text = "Rendszergazdai fiók létrehozása";
                LBL_warning1.Visible = false;
                LBL_warning2.Visible = false;
                LBL_message.Text = "Írja be a kívánt felhasználónevet valamint jelszavat és kattintson a létrehozás gombra.";
                BT_delete.Text = "Létrehozás";
            }
            else if (type == "deletesysadmin")
            {
                this.Text = "Rendszergazdai fiók törlése";
                LBL_warning1.Visible = true;
                LBL_warning2.Visible = true;
                LBL_message.Text = "Írja be a kívánt felhasználónevet valamint jelszavat és kattintson a törlés gombra.";
                BT_delete.Text = "Törlés";
            }
        }

        private void BT_back_Click(object sender, EventArgs e)
        {
            Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
            this.Hide();
            chwindow.Closed += (s, args) => this.Close();
            chwindow.Show();
        }

        private void BT_delete_Click(object sender, EventArgs e)
        {
            if (this.Text == "Felhasználói fiók törlése")
            {
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    string command = "DELETE FROM users WHERE username='" + TB_username.Text + "'and password='" + TB_password.Text + "'";
                    sqlcmd.CommandText = command;
                    sqlcmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("A művelet végrehajtásra került! Kérjük ellenőrízze az eredményességét az aktuális felhasználói fiókok fül alatt.");
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
            }
            else if (this.Text == "Felhasználói fiók létrehozása")
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
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
            }
            else if (this.Text == "Rendszergazdai fiók törlése")
            {
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    string command = "DELETE FROM sysadmins WHERE username='" + TB_username.Text + "'and password='" + TB_password.Text + "'";
                    sqlcmd.CommandText = command;
                    sqlcmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("A művelet végrehajtásra került! Kérjük ellenőrízze az eredményességét az aktuális rendszergazdai fiókok fül alatt.");
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
            }
            else
            {
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    string command = "INSERT INTO sysadmins(username,password) VALUES('" + TB_username.Text + "','" + TB_password.Text + "')";
                    sqlcmd.CommandText = command;
                    sqlcmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("A művelet végrehajtásra került! Kérjük ellenőrízze az eredményességét az aktuális rendszergazdai fiókok fül alatt.");
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
            }
        }
    }
}
