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
    public partial class Form1 : Form
    {
        SqlConnection con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\visual studio projects\Railway management system\Database1.mdf"";Integrated Security=True");
        string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            con.Open();

            try
            {
                string query = "select * from Railwaysystemlogin where Username=@UserName and Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();


                if(reader.Read())
                {
                    MessageBox.Show("Login succesfull", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm f2 = new MainForm();
                    f2.Show();
                }
                else
                {
                    
                    MessageBox.Show("Invalid Login  Credentials", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error while searching", "Railway login system", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            { 
                con.Close();
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
