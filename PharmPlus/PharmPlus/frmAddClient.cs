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
    public partial class frmAddClient : Form
    {
        SqlConnection conn = new SqlConnection(Globals.DBConn);
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = txBxID.Text;
            string Name = txBxName.Text;
            string Surname = txBxSurname.Text;
            string Address = txBxAddress.Text;
            string MedAid = txBxMedAidNum.Text;
            string MedCondition = txBxMedCondition.Text;

            if (ID == "" || ID.Length != 13)
            {
                MessageBox.Show("Please enter in a valid ID number!");
            }
            else
            {
                if (Name == "")
                {
                    MessageBox.Show("Please enter in a valid name!");
                }
                else
                {
                    if (Surname == "")
                    {
                        MessageBox.Show("Please enter in a valid surname!");
                    }
                    else
                    {
                        if (Address == "")
                        {
                            MessageBox.Show("Please enter in a valid address!");
                        }
                        else
                        {
                            if (MedAid == "")
                            {
                                MessageBox.Show("Please enter in a valid medical aid number");
                            }
                            else
                            {
                                if (MedCondition == "")
                                {
                                    MessageBox.Show("Please enter in a valid ID number");
                                }
                                else
                                {
                                    try
                                    {
                                        conn.Open();
                                        SqlCommand commmand = new SqlCommand("SELECT ClientID FROM tbClients WHERE ClientID = @id", conn);
                                        commmand.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.VarChar)).Value = ID;

                                        SqlDataReader dR = commmand.ExecuteReader();

                                        if (dR.HasRows)
                                        {
                                            MessageBox.Show("Client already exists! Can not create a duplicate client!");
                                            return;
                                        }
                                        else
                                        {
                                            commmand = new SqlCommand("INSERT INTO tbClients VALUES ('" + 
                                                ID + "','" + Name + "','" + Surname + "','" + Address + "','" + MedAid + "','" + MedCondition + "')", conn);
                                            dR.Close();
                                            dR = commmand.ExecuteReader();
                                            MessageBox.Show("Client created successfully!");
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
            }
        }

        private void txBxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxMedAidNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxMedCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txBxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
