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

namespace Railway_management_system
{
    public partial class Travel_Master : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");

        public Travel_Master()
        {
            InitializeComponent();
            populate();
            FillGCBTraincode();
        }

        private void FillGCBTraincode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TrainID from Trainmaster", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainID", typeof(int));
            dt.Load(rdr);
            GCBTravelcode.ValueMember = "TrainID";
            GCBTravelcode.DataSource = dt;
            con.Close();
            
        }
        private void populate()
        {
            con.Open();
            string query = "select *  from TravelMaster";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            DGTravel.DataSource = ds.Tables[0];
            con.Close();
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GBtnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";

            using(SqlConnection con=new SqlConnection(connectionString)) 
            {
                con.Open();

                string query = "Insert into TravelMaster (Date,Travelcode,Source,Destination,Travelcost)" + "VALUES(@Date,@TravelCode,@Source,@Destination,@Travelcost)";

                using (SqlCommand cmd=new SqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@Date", GDTDate.Value.Date);
                    cmd.Parameters.AddWithValue("@TravelCode", GCBTravelcode.Text);
                    cmd.Parameters.AddWithValue("@Source",GCBSource.Text);
                    cmd.Parameters.AddWithValue("@Destination", GCBDestination.Text);
                    cmd.Parameters.AddWithValue("@TravelCost", txtTravelcost.Text);
                    


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GCBTravelcode.Focus();
                    }

                }
            }
        }

        private void GBtnUpdate_Click(object sender, EventArgs e)
        {
            
            //
        }

        private void GBtnDel_Click(object sender, EventArgs e)
        {
            //sql query
            string deletesql = "delete from TravelMaster where TravelCode='" + GCBTravelcode.Text + "' ";
            //sql command
            SqlCommand cmd = new SqlCommand(deletesql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MessageBox.Show("record deleted succesfully.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
            }

            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm f2=new MainForm();
            f2.Show();
        }

        private void Travel_Master_Load(object sender, EventArgs e)
        {

        }

        private void GBtnClear_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are your sure , Do you  really want to EXIT from this", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            //{
            //    Application.Exit();

            //}
        }
    }
}
