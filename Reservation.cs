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
    public partial class Reservation : Form
    {
        string pname,date,source,dest,cost;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");
        public Reservation()
        {
            InitializeComponent();
            populate();
            FillPassengerID();
            FillTravelcode();
        }

        private void FillPassengerID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassengerID from PassengerMaster", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassengerID", typeof(int));
            dt.Load(rdr);
            GCBPassengerID.ValueMember = "PassengerID";
            GCBPassengerID.DataSource = dt;
            con.Close();

        }
        private void populate()
        {
            con.Open();
            string query = "select *  from Reservation";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            ReservationMGD.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillTravelcode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TravelCode from TravelMaster", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TravelCode", typeof(string));
            dt.Load(rdr);
            GCBTravelcode.ValueMember = "TravelCode";
            GCBTravelcode.DataSource = dt;
            con.Close();

        }

        private void GBtnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are your sure , Do you  really want to EXIT from this", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            //{
            //    Application.Exit();

            //}
        }

        private void GetPassengerName()
        {
            con.Open();
            string query= "select * from PassengerMaster where PassengerID="+GCBPassengerID.SelectedValue.ToString()+"";
            SqlCommand cmd =new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                pname = dr["PassengerName"].ToString();
            }
            con.Close();
            MessageBox.Show(pname);
        }
        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void GCBPassengerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPassengerName();
        }

        private void GBtnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


            using(SqlConnection con=new SqlConnection(connectionString)) 
            {
                con.Open();

                string query="INSERT into Reservation values("+GCBPassengerID.SelectedValue.ToString()+",'"+ pname + "','"+GCBTravelcode.SelectedValue.ToString()+"','"+date+"','"+source+"','"+dest+"','"+cost+"')";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation added succesfully");
                con.Close();
                populate();
            }
        }
    }
}
