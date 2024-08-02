using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Railway_management_system
{
    public partial class Train_master : Form
    {

        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");
        string train_name;
        int train_cap;
        public Train_master()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select *  from Trainmaster";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            var ds=new DataSet();
            sda.Fill(ds);
            GDTrainlist.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Train_master_Load(object sender, EventArgs e)
        {
            
        }

        private void GBtnAdd_Click(object sender, EventArgs e)
        {
            if(GRbtBusy.Checked) 
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


                using(SqlConnection con=new SqlConnection(connectionString)) 
                {
                    con.Open();

                    string query = "Insert into Trainmaster (TrainName,TrainCapacity,TrainStatus)" + "values(@TrainName,@TrainCapacity,@TrainStatus)";

                    using(SqlCommand cmd = new SqlCommand(query, con)) 
                    {
                        cmd.Parameters.AddWithValue("@TrainName",txtTrainName.Text);
                        cmd.Parameters.AddWithValue("@TrainCapacity", txtTrainCapacity.Text);
                        cmd.Parameters.AddWithValue("@TrainStatus", GRbtBusy.Text);

                        int rowsAffected=cmd.ExecuteNonQuery();
                        if (rowsAffected > 0) 
                        {
                            MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTrainName.Focus();
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

                    string query = "Insert into Trainmaster (TrainName,TrainCapacity,TrainStatus)" + "values(@TrainName,@TrainCapacity,@TrainStatus)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TrainName", txtTrainName.Text);
                        cmd.Parameters.AddWithValue("@TrainCapacity", txtTrainCapacity.Text);
                        cmd.Parameters.AddWithValue("@TrainStatus", GRbtAvai.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Succesfully Added", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Fail to Add ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTrainName.Focus();
                        }
                    }
                }
            }
        }

        private void txtTrainName_Leave(object sender, EventArgs e)
        {
            string TrainStatus;

            try
            {
                train_name = txtTrainName.Text;

                string query_search="select * from Trainmaster where TrainName='"+txtTrainName.Text +"' ";
                SqlCommand cmd=new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while(r.Read()) 
                {
                    ///txtTrainName.Text = r[1].ToString();
                    txtTrainCapacity.Text = r[1].ToString();
                   // GRbtBusy.Text = r[2].ToString();
                    //GRbtAvai.Text= r[3].ToString();
                    TrainStatus = r[2].ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error while searching..." + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void GBtnUpdate_Click(object sender, EventArgs e)
        {
            string TrainStatus;
            if (GRbtBusy.Checked) 
            {
                TrainStatus = "Busy";
            }
            else
            {
                TrainStatus = "Available";
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                con.Open();

                string query = "update Trainmaster set TrainName=@TrainName, TrainCapacity=@TrainCapacity,TrainStatus=@TrainStatus  where TrainName=@TrainName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TrainName", txtTrainName.Text);
                    cmd.Parameters.AddWithValue("@TrainCapacity", txtTrainCapacity.Text);
                    cmd.Parameters.AddWithValue("@TrainStatus",TrainStatus);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Succesfully Updated", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Fail to uppdate ,Try  Again", "Train Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTrainName.Focus();
                    }
                }
            }
        }

        private void GBtnDel_Click(object sender, EventArgs e)
        {
            //sql query
            string deletesql = "delete from Trainmaster where TrainName='" + txtTrainName.Text + "' ";
            //sql command
            SqlCommand cmd = new SqlCommand(deletesql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Are your sure , Do you  really want to Delete this record...", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                MessageBox.Show("record deleted succesfully.", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void GBtnClear_Click(object sender, EventArgs e)
        {
            txtTrainName.Clear();
            txtTrainCapacity.Clear();
            GRbtBusy.Text = string.Empty;
            GRbtAvai.Text = string.Empty;
            txtTrainName.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.Show();
        }
    }
}
