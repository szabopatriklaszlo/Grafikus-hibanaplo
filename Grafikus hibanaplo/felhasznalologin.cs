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
    public partial class Form1 : Form
    {
        public Form1(string fajta)
        {
            InitializeComponent();
            if (fajta == "user")
            {
                LBL_message.Text = "Ön a felhasználói belépést választotta!";
                this.Text = "Felhasználói bejelentkezés";
            }
            else
            {
                LBL_message.Text = "Ön a rendszergazdai belépést választotta!";
                this.Text = "Rendszergazdai bejelentkezés";
            }

        }

        private void BT_back_Click(object sender, EventArgs e)
        {
            Start chwindow = new Start();
            this.Hide();
            chwindow.Closed += (s, args) => this.Close();
            chwindow.Show();
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            if (LBL_message.Text == "Ön a felhasználói belépést választotta!")
            {
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    string command = "SELECT * FROM users WHERE username='" + TB_username.Text + "' and password ='" + TB_password.Text + "'"; ;
                    sqlcmd.CommandText = command;
                    DataTable datatable = new DataTable();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    dataadapter.Fill(datatable);

                    int i = datatable.Rows.Count;
                    if (i == 0)
                    {
                        MessageBox.Show("Hibás felhasználónév vagy jelszó!");
                    }
                    else
                    {
                        MessageBox.Show("A belépés sikeres! ");
                        felhasznaloibejelento userreporter = new felhasznaloibejelento();
                        this.Hide();
                        userreporter.Closed += (s, args) => this.Close();
                        userreporter.Show();
                    }
                    myConn.Close();
                }
                catch (Exception )
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
                    string command = "SELECT * FROM sysadmins WHERE username='" + TB_username.Text + "' and password ='" + TB_password.Text + "'"; ;
                    sqlcmd.CommandText = command;
                    DataTable datatable = new DataTable();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    dataadapter.Fill(datatable);

                    int i = datatable.Rows.Count;
                    if (i == 0)
                    {
                        MessageBox.Show("Hibás felhasználónév vagy jelszó!");
                    }
                    else
                    {
                        MessageBox.Show("A belépés sikeres!");
                        Rendszergazdavalasztofelulet sysadminchoise = new Rendszergazdavalasztofelulet();
                        this.Hide();
                        sysadminchoise.Closed += (s, args) => this.Close();
                        sysadminchoise.Show();
                    }
                    myConn.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
            }
           
        }
    }
}
