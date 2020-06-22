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
using System.Net;
using System.Net.Mail;
namespace Grafikus_hibanaplo
{
    public partial class felhasznaloibejelento : Form
    {
        public felhasznaloibejelento()
        {
            InitializeComponent();
        }

        private void RB_computererror_MouseDown(object sender, MouseEventArgs e)
        {
            RB_networkerror.Checked = false;
            RB_othererror.Checked = false;
        }

        private void RB_networkerror_MouseDown(object sender, MouseEventArgs e)
        {
            RB_computererror.Checked = false;
            RB_othererror.Checked = false;
        }

        private void RB_othererror_MouseDown(object sender, MouseEventArgs e)
        {
            RB_computererror.Checked = false;
            RB_networkerror.Checked = false;
        }

        private void BT_report_Click(object sender, EventArgs e)
        {
            string typeofreport = " ";
            if (RB_computererror.Checked == true)
            {
                typeofreport = "Számítógép hibájának bejelentése";
            }
            else if (RB_networkerror.Checked == true)
            {
                typeofreport = "Hálózati hiba bejelentése";
            }
            else
            {
                typeofreport = "Egyéb hiba";
            }

            string nameofreporter = TB_nameofreporter.Text;
            string emailofreporter = TB_emailofreporter.Text;
            string phonenumberofreporter = TB_phonenumberofreporter.Text;
            string temp = Convert.ToString(DTP_dateofperception.Value);
            string[] timearray = temp.Split(' ');
            string dateofperception = timearray[0]+timearray[1]+timearray[2];
            string timeofperception = TB_timeofperception.Text;
            string longreport = TB_longreport.Text;

            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sqlcmd = myConn.CreateCommand();
                sqlcmd.CommandType = CommandType.Text;
                string command = "INSERT INTO reports (typeofreport,nameofreporter,emailofreporter,phonenumberofreporter,dateofperception,timeofperception,longreport) VALUES ('" + typeofreport +"'"+ ","+ "'" + nameofreporter + "'" + "," + "'" + emailofreporter + "'" + "," + "'" + phonenumberofreporter + "'" + "," + "'" + dateofperception + "'" + "," + "'" + timeofperception + "'" + "," + "'" + longreport + "'" + ")";
                sqlcmd.CommandText = command;
                sqlcmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("A hibát sikeresen bejelentette!");
                try
                {
                    myConn.Open();
                    sqlcmd = myConn.CreateCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    command = "SELECT * FROM email";
                    sqlcmd.CommandText = command;
                    DataTable datatable = new DataTable();
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    dataadapter.Fill(datatable);
                    string senderemail = "secret";
                    string senderemailpassword = "secret";
                    string systemadministratorsemail = "secret";

                    foreach (DataRow item in datatable.Rows)
                    {
                        object[] array = item.ItemArray;
                        systemadministratorsemail = Convert.ToString(array[0]);
                        senderemail= Convert.ToString(array[1]);
                        senderemailpassword = Convert.ToString(array[2]);
                    }
                    myConn.Close();
                    string message = "Kedves rendszergazda! A hibanapló szoftveren keresztül bejelentése érkezett! A bejelentés ideje:"+DateTime.Now;
                    
                    MailMessage msg = new MailMessage(senderemail, systemadministratorsemail, "Hiba bejelentés érkezett!", message);
                    msg.IsBodyHtml = true;
                    SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                    sc.UseDefaultCredentials = false;
                    NetworkCredential cre = new NetworkCredential(senderemail, senderemailpassword);
                    sc.Credentials = cre;
                    sc.EnableSsl = true;
                    sc.Send(msg);
                }
                catch (Exception)
                {

                    MessageBox.Show("A rendszer valamilyen hibát észlelt, a rendszergazda nem lett emailben kiértesítve! Kérem keresse fel személyesen!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
            }
            if (RB_computererror.Checked == true)
            {
                RB_computererror.Checked = false;
            }
            else if (RB_networkerror.Checked == true)
            {
                RB_networkerror.Checked = false;
            }
            else
            {
                RB_othererror.Checked = false;
            }
            TB_nameofreporter.Text = " ";
            TB_emailofreporter.Text = " ";
            TB_phonenumberofreporter.Text = " ";
            TB_timeofperception.Text = " ";
            TB_longreport.Text = " ";



        }
    }
}
