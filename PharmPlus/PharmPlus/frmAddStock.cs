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
    public partial class frmAddStock : Form
    {
        SqlConnection conn = new SqlConnection(Globals.DBConn);
        public frmAddStock()
        {
            InitializeComponent();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand commmand = new SqlCommand("SELECT MedName, MedBrand FROM tbMeds", conn);

                SqlDataReader dR = commmand.ExecuteReader();               

                if (dR.HasRows)
                {
                    while (dR.Read())
                    {
                        comboBox1.Items.Add(dR["MedName"] + " " + dR["MedBrand"]);
                    }
                }
                else
                {
                    MessageBox.Show("Medication created successfully!");
                }
                conn.Close();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error: " + Exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
