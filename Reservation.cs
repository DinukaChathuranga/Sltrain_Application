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
    public partial class Reservation : Form

    {
        int x, y, w, a,  c;
        int z = 0;int b = 0;
       
       
        public Reservation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Search_Trains grds = new Search_Trains();
            grds.Show();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cal_Click(object sender, EventArgs e)
        {
            if (this.tno.Text == "" || this.tname.Text == "" || this.cls.SelectedItem.ToString() == "" || this.numericUpDown1.Value.ToString() == "" || this.numericUpDown2.Value.ToString() == "")
            {
                MessageBox.Show("Please Complete All", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            
            string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM trains WHERE Train_No = '" + this.tno.Text + "' AND Train_Name ='" + this.tname.Text + "' AND Times='"+this.time.Text+"'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    x = Convert.ToInt32(this.numericUpDown1.Value);
                    y = Convert.ToInt32(this.numericUpDown2.Value);
                    z = x + y;
                    if (this.cls.SelectedIndex == 0)
                    {


                        w = Convert.ToInt32(dr.GetValue(6));
                        if (z <= w)
                        {
                            a = Convert.ToInt32(dr.GetValue(8));
                            b = (y * a) + (x * (a / 2));
                            this.Lamount.Text = b.ToString();



                        }
                        else
                        {
                            MessageBox.Show("Sorry,Not Available in 1st Class", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else if (this.cls.SelectedIndex == 1)
                    {
                        w = Convert.ToInt32(dr.GetValue(7));
                        if (z <= w)
                        {
                            a = Convert.ToInt32(dr.GetValue(9));
                            b = (y * a) + (x * (a / 2));
                            this.Lamount.Text = b.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Sorry,Not Available in 2nd class", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                { MessageBox.Show("We can Find this Train", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                con.Close();











            }
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            string c = MessageBox.Show("Proceed To Payment", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString();
            if (c == "OK")
            {



                Payment qw = new Payment();
                qw.pamount.Text = this.Lamount.Text;
                qw.Show();
                this.Close();
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
