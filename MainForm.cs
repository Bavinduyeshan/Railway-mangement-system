using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_management_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GBtnTrainMaster_Click(object sender, EventArgs e)
        {

            this.Hide();
            Train_master f3=new Train_master();
            f3.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passenger_Master f4 = new Passenger_Master();
            f4.Show();
        }

        private void GBtnTravelMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Travel_Master f4 = new Travel_Master();
            f4.Show();
        }

        private void GBtnreservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation f5 = new Reservation();
            f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are your sure , Do you  really want to EXIT from this", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            //{
            //    Application.Exit();
                
            //}
        }

        private void GBtnCancellation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancellation f6 = new Cancellation();
            f6.Show();

        }
    }
}
