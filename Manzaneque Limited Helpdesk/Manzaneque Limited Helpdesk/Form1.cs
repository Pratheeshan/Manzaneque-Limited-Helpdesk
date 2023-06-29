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

namespace Manzaneque_Limited_Helpdesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }


        private void loginbtn_Click(object sender, EventArgs e)
        {
          
        MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd = SQL123@; database = manzaneque; SslMode = None; "); 
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from help_desk where name = '" + usrnametxtbx.Text + "' AND password = '" + passwrdtxtbx.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Accessing Granted", "Login");
                Form2 f2 = new Form2(usrnametxtbx.Text);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username And Password Not Match!", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            usrnametxtbx.Text = string.Empty;
            passwrdtxtbx.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
            con.Close(); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
