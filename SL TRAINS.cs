using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sl_Trains
{
    public partial class SL_TRAINS : Form
    {
        public SL_TRAINS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservation ard = new Reservation();
            
            ard.Show();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void strains_Click(object sender, EventArgs e)
        {
            Search_Trains grd = new Search_Trains();
            grd.Show();
            

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login drs = new Login();
            
            drs.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
