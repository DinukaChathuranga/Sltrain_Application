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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if (this.Fname.Text == "" || this.Lname.Text == "" || this.Username.Text == "" || this.Pass.Text == "" || this.Cpass.Text == "")
            {

                MessageBox.Show("Can not Create a Account without this fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (this.Eadd.Text == "" && this.Mnum.Text == "")
            {
                MessageBox.Show("Please Enter a Email or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.Pass.Text != this.Cpass.Text)
            {
                MessageBox.Show("Password and Confirm Password are not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(Cpass, "");
            }
            else if (this.agreecheck.Checked == true)
            {
                int ret;
                string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                if (this.Eadd.Text == "")
                {
                    string sql = "INSERT INTO Users(First_Name,Last_Name,Mobile_Number,Username,Password) VALUES( '" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Mnum.Text + "','" + this.Username.Text + "','" + this.Pass.Text + "')";


                    SqlCommand com = new SqlCommand(sql, con);

                    ret = com.ExecuteNonQuery();
                }
                else if (this.Mnum.Text == "")
                {
                    string sql = "INSERT INTO Users(First_Name,Last_Name,Email_Address,Username,Password) VALUES( '" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Eadd.Text + "','" + this.Username.Text + "','" + this.Pass.Text + "')";


                    SqlCommand com = new SqlCommand(sql, con);

                    ret = com.ExecuteNonQuery();
                }
                else
                {
                    string sql = "INSERT INTO Users(First_Name,Last_Name,Emial_Address,Mobile_Number,Username,Password) VALUES( '" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Eadd + "','" + this.Mnum.Text + "','" + this.Username.Text + "','" + this.Pass.Text + "')";


                    SqlCommand com = new SqlCommand(sql, con);

                    ret = com.ExecuteNonQuery();
                }
                MessageBox.Show(ret + "Account Created Successfully", "Information", MessageBoxButtons.OK);
                con.Dispose();
            }
            else { errorProvider2.SetError(agreecheck, "can not create account without agree"); }
            



        }


        private void close_Click_1(object sender, EventArgs e)
        {
            Login fg = new Login();
            fg.Show();
            this.Hide();
        }
    }
}