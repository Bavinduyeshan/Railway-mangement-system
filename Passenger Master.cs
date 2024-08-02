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
    public partial class Passenger_Master : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");
        string passengername, passengereaddress;
        int contactno;
        public Passenger_Master()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select *  from PassengerMaster";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerMGD.DataSource = ds.Tables[0];
            con.Close();
        }
        private void GBtnAdd_Click(object sender, EventArgs e)
        {
            if (GRbtMale.Checked)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "Insert into PassengerMaster (PassengerName,PassengerAddress,Gender,ContactNo)" + "VALUES(@PassengerName,@PassengerAddress,@Gender,@ContactNo)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PassengerName", txtPassengerName.Text);
                        cmd.Parameters.AddWithValue("@PassengerAddress", txtPassengeraddreess.Text);
                        cmd.Parameters.AddWithValue("@Gender", GRbtMale.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContno.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassengerName.Focus();
                        }
                    }
                }
            }
            else
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "Insert into PassengerMaster (PassengerName,PassengerAddress,Gender,ContactNo)" + "VALUES(@Passengername,@Passengeraddress,@Gender,@ContactNo)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PassengerName", txtPassengerName.Text);
                        cmd.Parameters.AddWithValue("@PassengerAddress", txtPassengeraddreess.Text);
                        cmd.Parameters.AddWithValue("@Gender", GRbtFemale.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContno.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassengerName.Focus();
                        }
                    }
                }
            }
        }

        private void txtPassengerName_Leave(object sender, EventArgs e)
        {
            string Gender;

            try
            {
                passengername= txtPassengerName.Text;
                passengereaddress= txtPassengeraddreess.Text;


                string query_search = "select * from PassengerMaster where PassengerName='" + txtPassengerName.Text + "' ";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    ///txtTrainName.Text = r[1].ToString();
                    txtPassengerName    .Text = r[1].ToString();
                    // GRbtBusy.Text = r[2].ToString();
                    //GRbtAvai.Text= r[3].ToString();
                    txtPassengeraddreess .Text = r[2].ToString();
                    Gender = r[3].ToString();
                    txtContno.Text = r[4].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while searching..." + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GBtnUpdate_Click(object sender, EventArgs e)
        {
            string gender;
            if (GRbtMale.Checked)
            {
               gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "update PassengerMaster set PassengerName=@PassengerName, PassengerAddress=@PassengerAddress,Gender=@Gender ,ContactNo=@ContactNo where pasengername= @PassengerName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PassengerName", txtPassengerName.Text);
                    cmd.Parameters.AddWithValue("@PassengerAddress", txtPassengeraddreess.Text);
                    cmd.Parameters.AddWithValue("@Gender",gender );
                    cmd.Parameters.AddWithValue("@ContactNo ", txtContno.Text);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succesfully Updated", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("Fail to uppdate ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassengerName.Focus();
                    }
                }
            }
            populate();
        }

        private void GBtnDel_Click(object sender, EventArgs e)
        {
            //sql query
            string deletesql = "delete from PassengerMaster where PassengerName='" + txtPassengerName.Text + "' ";
            //sql command
            SqlCommand cmd = new SqlCommand(deletesql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MessageBox.Show("record deleted succesfully.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            populate();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm f2=new MainForm();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are your sure , Do you  really want to EXIT from this", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            //{
            //    Application.Exit();

            //}
        }

        private void Passenger_Master_Load(object sender, EventArgs e)
        {

        }
    }
}
