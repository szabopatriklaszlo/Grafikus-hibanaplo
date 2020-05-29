﻿using System;
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
    public partial class Aktualisrendszergazdaifiokok : Form
    {
        public Aktualisrendszergazdaifiokok()
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

        private void Aktualisrendszergazdaifiokok_Load(object sender, EventArgs e)
        {
            List<object> usernames = new List<object>();
            List<object> passwords = new List<object>();
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=root;database=hibanaplo;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sqlcmd = myConn.CreateCommand();
                sqlcmd.CommandType = CommandType.Text;
                string command = "SELECT * FROM sysadmins"; ;
                sqlcmd.CommandText = command;
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sqlcmd);
                sqlcmd.ExecuteNonQuery();
                dataadapter.Fill(datatable);


                foreach (DataRow item in datatable.Rows)
                {
                    object[] array = item.ItemArray;
                    usernames.Add(array[0]);
                    passwords.Add(array[1]);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz!");
            }
            for (int i = 0; i < usernames.Count; i++)
            {
                LB_users.Items.Add(usernames[i]);
                LB_passwords.Items.Add(passwords[i]);
            }
        }
    }
}
