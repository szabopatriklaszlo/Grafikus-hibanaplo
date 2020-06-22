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
    public partial class Hibakkezelese : Form
    {
        List<object> ids = new List<object>();
        List<object> typeofreports = new List<object>();
        List<object> nameofreporters = new List<object>();
        List<object> emailofreporters = new List<object>();
        List<object> phonenumberofreporters = new List<object>();
        List<object> dateofperceptions = new List<object>();
        List<object> timeofperceptions = new List<object>();
        List<object> longreports = new List<object>();
        public Hibakkezelese(string type)
        {

            InitializeComponent();
            if (type == "old")
            {
                this.Text = "Lezárt hibák";
                LBL_message.Text = "Lezárt hibák";
                RB_closereport.Visible = false;
                LBL_spec1.Visible = false;
                LBL_spec2.Visible = false;
            }
            else
            {
                this.Text = "Aktuális hibák";
                LBL_message.Text = "Aktuális hibák";
                RB_closereport.Visible = true;
                LBL_spec1.Visible = true;
                LBL_spec2.Visible = true;

            }
        }

        private void BT_back_Click(object sender, EventArgs e)
        {
            Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
            this.Hide();
            chwindow.Closed += (s, args) => this.Close();
            chwindow.Show();
        }

        private void Aktualishibakmegtekintese_Load(object sender, EventArgs e)
        {
            if (LBL_message.Text == "Aktuális hibák")
            {
                try
                {
                    string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    string command = "SELECT * FROM reports"; ;
                    sqlcmd.CommandText = command;
                    DataTable datatable = new DataTable();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    dataadapter.Fill(datatable);
                    foreach (DataRow item in datatable.Rows)
                    {
                        object[] array = item.ItemArray;
                        ids.Add(array[0]);
                        typeofreports.Add(array[1]);
                        nameofreporters.Add(array[2]);
                        emailofreporters.Add(array[3]);
                        phonenumberofreporters.Add(array[4]);
                        dateofperceptions.Add(array[5]);
                        timeofperceptions.Add(array[6]);
                        longreports.Add(array[7]);
                    }
                    myConn.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
                for (int i = 0; i < ids.Count; i++)
                {
                    LB_ids.Items.Add(ids[i]);
                    LB_typeofreports.Items.Add(typeofreports[i]);
                    LB_nameofreporters.Items.Add(nameofreporters[i]);
                    LB_emailofreporters.Items.Add(emailofreporters[i]);
                    LB_phonenumberofreporters.Items.Add(phonenumberofreporters[i]);
                    LB_dateofperceptions.Items.Add(dateofperceptions[i]);
                    LB_timeofperceptions.Items.Add(timeofperceptions[i]);
                    LB_longreports.Items.Add(longreports[i]);
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
                    string command = "SELECT * FROM closedreports"; ;
                    sqlcmd.CommandText = command;
                    DataTable datatable = new DataTable();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    dataadapter.Fill(datatable);
                    foreach (DataRow item in datatable.Rows)
                    {
                        object[] array = item.ItemArray;
                        ids.Add(array[0]);
                        typeofreports.Add(array[1]);
                        nameofreporters.Add(array[2]);
                        emailofreporters.Add(array[3]);
                        phonenumberofreporters.Add(array[4]);
                        dateofperceptions.Add(array[5]);
                        timeofperceptions.Add(array[6]);
                        longreports.Add(array[7]);
                    }
                    myConn.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
                }
                for (int i = 0; i < ids.Count; i++)
                {
                    LB_ids.Items.Add(ids[i]);
                    LB_typeofreports.Items.Add(typeofreports[i]);
                    LB_nameofreporters.Items.Add(nameofreporters[i]);
                    LB_emailofreporters.Items.Add(emailofreporters[i]);
                    LB_phonenumberofreporters.Items.Add(phonenumberofreporters[i]);
                    LB_dateofperceptions.Items.Add(dateofperceptions[i]);
                    LB_timeofperceptions.Items.Add(timeofperceptions[i]);
                    LB_longreports.Items.Add(longreports[i]);
                }
            }
            

 
        }

        private void RB_showmessage_MouseDown(object sender, MouseEventArgs e)
        {
            RB_closereport.Checked = false;
        }

        private void RB_closereport_MouseDown(object sender, MouseEventArgs e)
        {
            RB_showmessage.Checked = false;
        }

        private void BT_start_Click(object sender, EventArgs e)
        {
            if (RB_showmessage.Checked == true)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (Convert.ToString(ids[i]) == TB_id.Text)
                    {
                        TB_longreporttext.Text = Convert.ToString(longreports[i]);
                        break;
                    }
                    else if (i == (ids.Count - 1))
                    {
                        MessageBox.Show("Nincs ilyen azonosítójú jelentés!");
                    }

                }
            }
            else if (RB_closereport.Checked == true)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (Convert.ToString(ids[i]) == TB_id.Text)
                    {
                        try
                        {
                            string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                            MySqlConnection myConn = new MySqlConnection(myConnection);
                            myConn.Open();
                            MySqlCommand sqlcmd = myConn.CreateCommand();
                            sqlcmd.CommandType = CommandType.Text;
                            string command = "INSERT INTO closedreports (typeofreport,nameofreporter,emailofreporter,phonenumberofreporter,dateofperception,timeofperception,longreport) VALUES ('"+Convert.ToString(typeofreports[i])+"','"+ Convert.ToString(nameofreporters[i]) + "','" + Convert.ToString(emailofreporters[i]) + "','" + Convert.ToString(phonenumberofreporters[i]) + "','" + Convert.ToString(dateofperceptions[i]) + "','"+ Convert.ToString(timeofperceptions[i]) + "','" + Convert.ToString(longreports[i]) + "')";
                            sqlcmd.CommandText = command; 
                            sqlcmd.ExecuteNonQuery();
                            command = "DELETE FROM reports WHERE ID='"+ Convert.ToString(ids[i])+"'";
                            sqlcmd.CommandText = command;
                            sqlcmd.ExecuteNonQuery();
                            myConn.Close();
                            MessageBox.Show("A művelet végre lett hajtva!");
                            Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
                            this.Hide();
                            chwindow.Closed += (s, args) => this.Close();
                            chwindow.Show();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        TB_longreporttext.Text = Convert.ToString(longreports[i]);
                        break;
                    }
                    else if (i == (ids.Count - 1))
                    {
                        MessageBox.Show("Nincs ilyen azonosítójú jelentés!");
                    }

                }
            }

        }
    }
}
