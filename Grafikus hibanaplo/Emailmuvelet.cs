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
    public partial class Emailmuvelet : Form
    {
        public Emailmuvelet()
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

        private void Emailmuvelet_Load(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sqlcmd = myConn.CreateCommand();
                sqlcmd.CommandType = CommandType.Text;
                string command = "SELECT * FROM email";
                sqlcmd.CommandText = command;
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                sqlcmd.ExecuteNonQuery();
                dataadapter.Fill(datatable);
                foreach (DataRow item in datatable.Rows)
                {
                    object[] array = item.ItemArray;
                    TB_actualsysemail.Text = Convert.ToString(array[0]);
                    TB_actualsenderemail.Text = Convert.ToString(array[1]);
                    TB_actualsenderpassword.Text = Convert.ToString(array[2]);
                }
                myConn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
            }
        }

        private void BT_change_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sqlcmd = myConn.CreateCommand();
                sqlcmd.CommandType = CommandType.Text;
                string command = "UPDATE email SET sysadminsemail = '"+TB_newsysemail.Text+"', senderemail = '"+TB_newsenderemail.Text+"', senderpassword = '"+TB_newsenderpassword.Text+"' WHERE senderemail = '"+TB_actualsenderemail.Text+"'";
                sqlcmd.CommandText = command;
                sqlcmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Az adatok sikeresen meg lettek változtatva!");
                Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
                this.Hide();
                chwindow.Closed += (s, args) => this.Close();
                chwindow.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
            }
        }
    }
}
