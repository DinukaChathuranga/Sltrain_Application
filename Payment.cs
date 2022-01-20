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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (this.cname.Text == "" || this.cno.Text == "" || this.exp.Text == "" || this.cvv.Text == "")
            { MessageBox.Show("INCOMPLETED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "SELECT * FROM card WHERE Card_Holder_Name = '" + this.cname.Text + "' AND Card_No ='" + this.cno.Text + "' AND Exp_date='" + this.exp.Text + "' AND Cvv='" + this.cvv.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    int x = Convert.ToInt32(dr.GetValue(5));
                    int y = Convert.ToInt32(this.pamount.Text);
                    if (x >= y)
                    {
                        string msg = MessageBox.Show("Are you sure to proceed", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                        if (msg == "Yes")
                        {
                          string c=  MessageBox.Show( "Payment Successfully","Payment",MessageBoxButtons.OK).ToString();
                            if (c == "OK")
                            {
                                SL_TRAINS re = new SL_TRAINS();
                                re.Show();
                                this.Hide();
                            }


                        }
                        


                    }
                    else { MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("Chech Again", "Inavalid Card", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                con.Dispose();

            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.debit.Checked = true;
            this.toolTip1.SetToolTip(this.cno, "Must have 16 characters");
            this.toolTip2.SetToolTip(this.cvv, "Enter 3 characters No");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Reservation er = new Reservation();
            er.Show();

            er.Hide();
            
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            Reservation er = new Reservation();
            er.Show();
            this.Close();
        }
    }
}
