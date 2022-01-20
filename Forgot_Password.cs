using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sl_Trains
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Users WHERE Username = '" + this.uname.Text + "' ";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                string x, y, z, w;
                x = dr.GetValue(1).ToString();
                y = dr.GetValue(2).ToString();
                z = dr.GetValue(3).ToString();
                w = dr.GetValue(4).ToString();
                if (this.fname1.Text == x && this.lname1.Text == y && this.Email1.Text == z && this.Mno1.Text == w)
                {
                    this.pass.Text = dr.GetValue(6).ToString();

                }
                else
                {
                    MessageBox.Show("Can't Find a Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Can Not Find a Account with this Username", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            this.uname.Clear();
            this.fname1.Clear();
            this.lname1.Clear();
            this.Email1.Clear();
            this.Mno1.Clear();
            this.pass.Clear();
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            Login lk = new Login();
            lk.Show();
            this.Hide();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
