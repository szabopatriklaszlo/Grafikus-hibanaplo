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
    public partial class Lezarthibakmegtekintese : Form
    {
        List<object> ids = new List<object>();
        List<object> typeofreports = new List<object>();
        List<object> nameofreporters = new List<object>();
        List<object> emailofreporters = new List<object>();
        List<object> phonenumberofreporters = new List<object>();
        List<object> dateofperceptions = new List<object>();
        List<object> timeofperceptions = new List<object>();
        List<object> longreports = new List<object>();
        public Lezarthibakmegtekintese()
        {
            InitializeComponent();
        }

        private void Lezarthibakmegtekintese_Load(object sender, EventArgs e)
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
            catch (Exception ex)
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

        private void BT_back_Click(object sender, EventArgs e)
        {
            Rendszergazdavalasztofelulet chwindow = new Rendszergazdavalasztofelulet();
            this.Hide();
            chwindow.Closed += (s, args) => this.Close();
            chwindow.Show();
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
         }
     }
 }
