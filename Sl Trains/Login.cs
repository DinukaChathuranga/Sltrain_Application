using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;










namespace Sl_Trains
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Username.Text == "" && this.Password.Text == "")
            {
                errorProvider1.SetError(Username, "Please Enter Username ");
                errorProvider1.SetError(Password, "Please Eneter Password");
            }
            else if (this.Username.Text == "")
            {
                errorProvider1.SetError(Username, "Please Enter Username");
            }
            else if (this.Password.Text == "")
            {
                errorProvider1.SetError(Password, "Please Enter Password");
            }
            else
            {

                string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "SELECT * FROM Users WHERE Username = '" + this.Username.Text + "' AND Password ='" + this.Password.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    SL_TRAINS main = new SL_TRAINS();
                    main.Show();
                    this.Hide();

                }
                else 
                {
                    MessageBox.Show("Username or Password Invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Dispose();
            }
            
          

            
            
    


        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Registration gr = new Registration();
            gr.Show();
            this.Hide();

        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fr = new Forgot_Password();

            fr.Show();
            this.Hide();

            

        }
    }
}
