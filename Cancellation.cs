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
    public partial class Cancellation : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");
        public Cancellation()
        {
            InitializeComponent();
            populate();
            FillTicketID();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Cancellation";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            var ds=new DataSet();
            sda.Fill(ds);
            CancellationMGD.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillTicketID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Ticketid from Reservation", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ticketid", typeof(string));
            dt.Load(rdr);
            GCBTicketid.ValueMember = "Ticketid";
            GCBTicketid.DataSource = dt;
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {

        }

        private void GBtnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";

            using(SqlConnection con=new SqlConnection(connectionString)) 
            {
                con.Open();
                string query2 = "INSERT INTO Cancellation Values("+GCBTicketid.SelectedValue.ToString()+",'"+DateTime.Today.Date+"')";
                SqlCommand cmd=new SqlCommand(query2, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cancellation added succesfully");
                con.Close();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
