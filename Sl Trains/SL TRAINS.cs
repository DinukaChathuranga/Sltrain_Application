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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void strains_Click(object sender, EventArgs e)
        {
            Search_Trains grd = new Search_Trains();
            grd.MdiParent = this;
            grd.Show();

        }

        private void reservs_Click(object sender, EventArgs e)
        {
            Reservation erd = new Reservation();
            erd.MdiParent = this;
            erd.Show();



        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login sad = new Login();
            sad.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
