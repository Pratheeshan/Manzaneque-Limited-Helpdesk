using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manzaneque_Limited_Helpdesk
{
    public partial class Form2 : Form
    {
        public Form2(string s)
        {
            InitializeComponent();
            textBox1.Text = s;

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are Your Going to logout?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogresult == DialogResult.Yes)
            {
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();

            }

        }

        private void btncallLog_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(textBox1.Text);
            F3.Show();
            this.Hide();
        }

        private void btnresolution_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4("");
            F4.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}
 