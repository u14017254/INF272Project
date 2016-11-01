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


namespace PharmPlus
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(Globals.DBConn);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Globals.username = txtBxUsername.Text;
            try
            {
                conn.Open();
                string id = txtBxUsername.Text;
                string password = txtBxPassword.Text;
                SqlCommand commmand = new SqlCommand("SELECT UserUsername, UserPassword FROM tbUserLogin WHERE UserUsername = @id AND UserPassword = @password ", conn);
                commmand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.VarChar)).Value = id;
                commmand.Parameters.Add(new SqlParameter("@password", System.Data.SqlDbType.VarChar)).Value = password;
                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    frmMainMenu mmfrm = new frmMainMenu();
                    mmfrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and/or password!");
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }
    }
}