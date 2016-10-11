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
    public partial class frmMainMenu : Form
    {
        SqlConnection conn = new SqlConnection(Globals.DBConn);
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void menuItem1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbMeds", conn);
                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {                    
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No medication in the database!");
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbClients", conn);
                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No clients in the database!");
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbMeds", conn);
                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No medication in the database!");
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string med = "";
                conn.Open();
                med = Microsoft.VisualBasic.Interaction.InputBox("Type the medication to search for:", "Search Medication", "e.g. Asprin");
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbMeds WHERE MedName LIKE '%'+ @med + '%'", conn);
                commmand.Parameters.Add(new SqlParameter("@med", System.Data.SqlDbType.VarChar)).Value = med;

                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    if (med != "")
                    {
                        MessageBox.Show("Medication not found!");
                    }
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddClient frmAdd = new frmAddClient();
            frmAdd.Show();
        }

        private void byClientIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                conn.Open();
                id = Microsoft.VisualBasic.Interaction.InputBox("Type the ClientID to search for:", "Search Client", "e.g. 9604235362081");
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbClients WHERE ClientID = @id", conn);
                commmand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.VarChar)).Value = id;

                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    if (id != "")
                    {
                        MessageBox.Show("Client not found!");
                    }
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                conn.Open();
                name = Microsoft.VisualBasic.Interaction.InputBox("Type the client name to search for:", "Search Client", "e.g. Cameron");
                SqlCommand commmand = new SqlCommand("SELECT * FROM tbClients WHERE ClientName = @name", conn);
                commmand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar)).Value = name;

                SqlDataReader dR = commmand.ExecuteReader();

                if (dR.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dR);
                    dgvMainMenu.DataSource = dataTable;
                }
                else
                {
                    if (name != "")
                    {
                        MessageBox.Show("Client not found!");
                    }
                }

                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void medicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMedication frmAdd = new frmAddMedication();
            frmAdd.Show();
        }
    }
}
