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
    public partial class Search_Trains : Form
    {
        public Search_Trains()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Reservation cw = new Reservation();
            cw.tno.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cw.tname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cw.time.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cw.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (this.from.SelectedItem.ToString() == "" || this.to.SelectedItem.ToString() == "" || this.starttime.SelectedItem.ToString() == "" || this.endtime.SelectedItem.ToString() == "") { MessageBox.Show("Please Insert All", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string cs = "Data Source=LAPTOP-LUDI7TH2;Initial Catalog=Sltrains;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "SELECT Train_No,Train_Name,Times,Start_Station,End_Station,first_class_Price,Second_class_price FROM trains WHERE Start_Station = '" + this.from.SelectedItem.ToString() + "' AND End_Station = '" + this.to.SelectedItem.ToString() + "'AND Times>='" + this.starttime.SelectedItem.ToString() + "'AND Times <='" + this.endtime.SelectedItem.ToString() + "' AND Date = '" + this.dateTimePicker1.Text + "'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
                DataSet dtbl = new DataSet();
                sqlda.Fill(dtbl);

                if (dtbl.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = dtbl.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Trains Available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
                
            

        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            SL_TRAINS grf = new SL_TRAINS();
            grf.Show();
            this.Close();
        }

        private void Search_Trains_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.dataGridView1, "Select Which Train you want to travel");
        }

        private void Search_Trains_Load_1(object sender, EventArgs e)
        {
            this.toolTip2.SetToolTip(this. from, "Select Your Start Station");
            this.toolTip2.SetToolTip(this.to, "Select Your End Station");

            this.toolTip1.SetToolTip(this.dataGridView1, "Select Which Train you want to travel");
        }
    }
}
