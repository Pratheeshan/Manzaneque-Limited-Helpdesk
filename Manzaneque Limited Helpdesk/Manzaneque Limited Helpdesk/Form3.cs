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
    public partial class Form3 : Form
    {
        public Form3(string s)
        {
            InitializeComponent();
            txtopName.Text = s;
        }
        String connstring = "server=localhost;uid=root;pwd=SQL123@;database=manzaneque;SslMode=None;";
        private void lblName_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            fillcombobox();
            fillcomboboxforSearch();
            previouspanel.Visible = false;
            specialistpanel.Visible = false;
            dataGridView1.DataSource = null;
        }
        private void fillcombobox()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select  problemtype_name from problem_type", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbprblmtype.DataSource = dt;
            cmbprblmtype.DisplayMember = "problemtype_name";
            cmbprblmtype.ValueMember = "problemtype_name";


            con.Close();

        }
 
        private void fillcomboboxforSearch()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select  problemtype_name from problem_type", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbprevious.DataSource = dt;
            cmbprevious.DisplayMember = "problemtype_name";
            cmbprevious.ValueMember = "problemtype_name";

            con.Close();

        }

        private void btnpersoneel_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from personnel", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            dataGridView1.DataSource = dttbl;

            con.Close();
        }

        private void btnprepblm_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from problem WHERE solution !=''", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            dataGridView1.DataSource = dttbl;

            con.Close();
            previouspanel.Visible = true;
            specialistpanel.Visible = false;
            softwarepanel.Visible = false;
        }

        private void btnspecialist_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from specialist", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);
            dataGridView1.DataSource = dttbl;

            con.Close();
            previouspanel.Visible = false;
            specialistpanel.Visible = true;
            softwarepanel.Visible = false;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (txtcallName.Text == "")
            {
                MessageBox.Show("Please fill the Name", "Alert");
            }
            else
            {
                String caller = txtcallName.Text;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from personnel where name='" + caller + "'", con);
                DataTable dttbl = new DataTable();
                dtadpt.Fill(dttbl);

                if (dttbl.Rows.Count > 0)
                {

                    dataGridView1.DataSource = dttbl;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnsfind_Click(object sender, EventArgs e)
        {

            if (txtserialNum.Text == "")
            {
                MessageBox.Show("Please fill the Serial Number", "Alert");
            }
            else
            {
                String serial = txtserialNum.Text;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from equipment where serial_number='" + serial + "'", con);
                DataTable dttbl = new DataTable();
                dtadpt.Fill(dttbl);

                if (dttbl.Rows.Count > 0)
                {

                    dataGridView1.DataSource = dttbl;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Serial Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchHelpDesk();
            getCaller();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string insert = "insert into problem (description,note,time_taken,solution,help_desk_help_desk_ID,specialist_specialist_ID,problem_type,serial_number,caller_name) values ('" + txtproblmDes.Text + "','" + txtnote.Text + "','" + null + "','" +
            null + "','" + textBox1.Text + "','" + 0 + "','" + cmbprblmtype.Text + "','" + txtserialNum.Text + "','" + txtcallName.Text + "')";
            string insert2 = "insert into caller (name,job_title,Department,call_time) values ('" + txtcallName.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +txttimeDate.Text + "')";
            string allqueries = string.Join(";",insert, insert2);
            MySqlCommand cmd1 = new MySqlCommand(allqueries, con);
            cmd1.ExecuteNonQuery();
            con.Close();

    
            MessageBox.Show("The problem is solved", "Message");
            Form4 f4 = new Form4(txtserialNum.Text);
            f4.Show();
            this.Hide();



        }

        private void searchHelpDesk()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            string search = "Select *from help_desk  where name='" + txtopName.Text + "'";
            MySqlCommand cmd = new MySqlCommand(search, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                textBox1.Text = r["help_desk_ID"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getCaller()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            string search = "Select * from personnel  where name='" + txtcallName.Text + "'";
            MySqlCommand cmd = new MySqlCommand(search, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                textBox2.Text = r["job_title"].ToString();
                textBox3.Text= r["department"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtlicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtcallName.Clear();
            txttimeDate.Clear();
            txtserialNum.Clear();
            txtproblmDes.Clear();
            txtnote.Clear();
            txtspclid.Clear();
        
        }

        private void cmbspcl_SelectedIndexChanged(object sender, EventArgs e)
        {
            String spcl = cmbspcl.Text;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from specialist where problemtype_expertise='" + spcl + "'", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);

            if (dttbl.Rows.Count > 0)
            {

                dataGridView1.DataSource = dttbl;
                con.Close();

            }
        }

        private void cmbprevious_SelectedIndexChanged(object sender, EventArgs e)
        {
            String prev = cmbprevious.Text;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from problem where problem_type='" + prev + "' AND solution !=''", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);

            if (dttbl.Rows.Count > 0)
            {

                dataGridView1.DataSource = dttbl;
                con.Close();

            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            txtspclid.ReadOnly = false;
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            searchHelpDesk();
            getCaller();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string insert = "insert into problem (description,note,time_taken,solution,help_desk_help_desk_ID,specialist_specialist_ID,problem_type,serial_number,caller_name) values ('" + txtproblmDes.Text + "','" + txtnote.Text + "','" + null + "','" +
            null + "','" + textBox1.Text + "','" + txtspclid.Text + "','" + cmbprblmtype.Text + "','" + txtserialNum.Text + "','" + txtcallName.Text + "')";
            string insert2 = "insert into caller (name,job_title,Department,call_time) values ('" + txtcallName.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + txttimeDate.Text + "')";
            string update = "update specialist set current_load=current_load + 1  where specialist_ID ='" + txtspclid.Text + "'";
            string allqueries = string.Join(";", insert, insert2,update);
            MySqlCommand cmd1 = new MySqlCommand(allqueries, con);
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("The problem trasfered to specialist", "Message");

        }

        private void specialistpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2("");
            F2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsoftware_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from software", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl); 
            dataGridView1.DataSource = dttbl;

            con.Close();
           previouspanel.Visible = false;
            specialistpanel.Visible = false;
            softwarepanel.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String equip = txtequipID.Text;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter dtadpt = new MySqlDataAdapter("select * from software where Equipment_ID='" + equip + "'", con);
            DataTable dttbl = new DataTable();
            dtadpt.Fill(dttbl);

                dataGridView1.DataSource = dttbl;
                con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
