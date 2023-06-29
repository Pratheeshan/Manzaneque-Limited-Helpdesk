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
    public partial class Form4 : Form
    {
        public Form4(string s)
        {
            InitializeComponent();
            txtserialNum.Text = s;
        }
        String connstring = "server=localhost;uid=root;pwd=SQL123@;database=manzaneque;SslMode=None;";
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void lbltimeDate_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from problem where serial_number='" + txtserialNum.Text + "' AND solution =''", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            if (dttbl.Rows.Count > 0)
            {

                dataGridView1.DataSource = dttbl;
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Serial number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            string search = "Select * from problem  where problem_ID='" + txtprblmId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(search, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                txtopName.Text = r["help_desk_help_desk_ID"].ToString();
                txtcallName.Text = r["caller_name"].ToString();
                txtprblmtype.Text = r["problem_type"].ToString();
                txtactprblm.Text = r["description"].ToString();
                txtspecialist.Text = r["specialist_specialist_ID"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string update = "update problem set solution ='" + txtsolution.Text + "',time_taken = '" + txttimetaken.Text + "' where problem_ID = '"+txtprblmId.Text+"' ";
            string update1 = "update specialist set current_load=current_load - 1  where specialist_ID ='" + txtspecialist.Text + "'";
            string allqueries = string.Join(";", update,  update1);
            MySqlCommand cmd1 = new MySqlCommand(allqueries, con);
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("The problem is solved", "Message");
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2("");
            F2.Show();
            this.Hide();
        }
    }
}
