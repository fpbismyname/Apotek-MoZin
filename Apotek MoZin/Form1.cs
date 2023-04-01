using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek_MoZin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string constring = "Server = localhost ; database = apotek_mofin ; uid = root ; pwd = Fajar12BuDiman ;" ;
            MySqlConnection con = new MySqlConnection(constring);


            try
            {
                con.Open();
                MessageBox.Show("Database Connected");
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
