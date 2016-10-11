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
    public partial class frmAddMedication : Form
    {
        SqlConnection conn = new SqlConnection(Globals.DBConn);
        public frmAddMedication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txBxName.Text;
            string Brand = txBxBrand.Text;
            string Supplier = txBxSupplier.Text;
            string Schedule = txBxSchedule.Text;
            
            if (Name == "")
            {
                MessageBox.Show("Please enter in a valid name!");
            }
            else
            {
                if (Brand == "")
                {
                    MessageBox.Show("Please enter in a valid brand name!");
                }
                else
                {
                    if (Supplier == "")
                    {
                        MessageBox.Show("Please enter in a valid supplier name!");
                    }
                    else
                    {
                        if (Schedule == "")
                        {
                            MessageBox.Show("Please enter in a valid medical aid number");
                        }
                        else
                        {
                            try
                            {
                                conn.Open();
                                SqlCommand commmand = new SqlCommand("SELECT MedID FROM tbMeds WHERE MedName = @name AND MedBrand = @brand AND MedSupplier = @supplier AND MedSchedule = @schedule", conn);
                                commmand.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar)).Value = Name;
                                commmand.Parameters.Add(new SqlParameter("@brand", System.Data.SqlDbType.VarChar)).Value = Brand;
                                commmand.Parameters.Add(new SqlParameter("@supplier", System.Data.SqlDbType.VarChar)).Value = Supplier;
                                commmand.Parameters.Add(new SqlParameter("@schedule", System.Data.SqlDbType.VarChar)).Value = Schedule;

                                SqlDataReader dR = commmand.ExecuteReader();

                                if (dR.HasRows)
                                {
                                    MessageBox.Show("Medication already exists! Can not create a duplicate medication!");
                                    return;
                                }
                                else
                                {
                                    commmand = new SqlCommand("INSERT INTO tbMeds VALUES ('" + Name + "','" + Brand + "','" + Supplier + "','" + Schedule + "')", conn);
                                    dR.Close();
                                    dR = commmand.ExecuteReader();
                                    MessageBox.Show("Medication created successfully!");
                                    this.Hide();
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
            }
        }

        private void frmAddMedication_Load(object sender, EventArgs e)
        {

        }
    }
}
