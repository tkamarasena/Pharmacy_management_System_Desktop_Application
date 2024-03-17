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
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml.Linq;

namespace WinFormsApp3
{
    public partial class Prescripttion : Form
    {
        Functions Con;
        public Prescripttion()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPrescrition();
            getPatient();

        }

        private void ShowPrescrition()
        {
            try
            {
                //textBox2.Focus();
                string Query = "SELECT * FROM Prescription";
                dataGridView1.DataSource = Con.GetData(Query);
            }
            catch
            {
                throw;
            }
        }

        private void getPatient()
        {
            string Query1 = "SELECT PatientId,PatientName FROM Patient";
            cmbPatientId.DisplayMember = Con.GetData(Query1).Columns["PatientId"].ToString();
            cmbPatientId.ValueMember = Con.GetData(Query1).Columns["PatientName"].ToString();
            cmbPatientId.DataSource = Con.GetData(Query1);


        }

        public class Prescription
        {
            /* private SqlConnection con;

             public Prescription(SqlConnection con)
             {
                 this.con = con;
             }

             public void DisplayPrescription(DataGridView dataGridView)
             {
                 try
                 {
                     txtEmpName.Focus();
                     string Query = "SELECT * FROM EmpTbl";
                     dgvEmployeeDetails.DataSource = Con.GetData(Query);
                 }
                 catch
                 {

                     throw;
                 }
             }*/
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1()
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_EDIT_Click(object sender, EventArgs e)
        {

        }

        private void ShowDataGridView1()
        {
            throw new NotImplementedException();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            object value = home.Show();
            this.Close();
        }

        private void Prescripttion_Load(object sender, EventArgs e)
        {
            ShowPrescrition();
        }

        /*private int GetCurrentValue()
        {
            int currentValue = 1; // Default initial value

            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("IncrementValue.txt", FileMode.OpenOrCreate, isoStore))
                    {
                        using (StreamReader reader = new StreamReader(isoStream))
                        {
                            string line = reader.ReadLine();
                            if (line != null)
                            {
                                currentValue = int.Parse(line);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (file not found, parsing error, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }

            return currentValue;
        }

        private void SaveValue(int value)
        {
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("IncrementValue.txt", FileMode.Create, isoStore))
                    {
                        using (StreamWriter writer = new StreamWriter(isoStream))
                        {
                            writer.WriteLine(value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (file creation error, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
        }*/

        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ADD_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbPatientId.SelectedIndex == -1 || txtPatientName.Text == "" || txt_Symptoms.Text == "" || txt_PrescripitionTest.Text == ""
                    || txt_medicines.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    int patientId = Convert.ToInt32(cmbPatientId.GetItemText(cmbPatientId.SelectedItem));
                    string symptoms = txt_Symptoms.Text;
                    string diagnostic = txt_PrescripitionTest.Text;
                    string medicine = txt_medicines.Text;
                    DateTime date = DateTime.Now.Date;

                    string Query2 = "INSERT INTO  Prescription VALUES('{0}','{1}','{2}','{3}','{4}')";
                    Query2 = string.Format(Query2, patientId, symptoms, diagnostic, medicine, date);
                    Con.SetData(Query2);
                    ShowPrescrition();
                    MessageBox.Show("Informations are Added!!");

                    cmbPatientId.SelectedIndex = -1;
                    txtPatientName.Text = "";
                    txt_Symptoms.Text = "";
                    txt_PrescripitionTest.Text = "";
                    txt_medicines.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPatientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //once you click any patient id on combo box, print related patient name in the text box
            txtPatientName.Text = cmbPatientId.GetItemText(cmbPatientId.SelectedValue);
        }

        int key;
        string name;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
                key = e.RowIndex;
                

                DataGridViewRow row = dataGridView1.Rows[key];
                lblPressId.Text = row.Cells[0].Value.ToString();
                cmbPatientId.Text = row.Cells[1].Value.ToString();
                txt_Symptoms.Text = row.Cells[2].Value.ToString();
                txt_PrescripitionTest.Text = row.Cells[3].Value.ToString();
                rtbTest.Text = row.Cells[3].Value.ToString();
                txt_medicines.Text = row.Cells[4].Value.ToString();
                rtbMedicine.Text = row.Cells[4].Value.ToString();
                

                string Query3 = "SELECT PatientName FROM Patient WHERE PatientId={0}";
                Query3 = string.Format(Query3, Convert.ToInt32(row.Cells[1].Value.ToString()));

                
                foreach (DataRow dr in Con.GetData(Query3).Rows)
                {
                    name = dr["PatientName"].ToString();
                    lblPatientName.Text = name;
                    txtPatientName.Text = name;
                }
                

            }
            catch
            {
                throw;
            }

        }

        private void btn_EDIT_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {

                    string Query = "DELETE FROM Patient WHERE PatientId = {0}";
                    Query = string.Format(Query, key + 1);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Eployee Is Deleted!!");
                    txt_patientName.Text = "";
                    txt_age.Text = "";
                    combo_gender.SelectedIndex = -1;
                    txt_contactno.Text = "";
                    combo_bloodgroup.SelectedIndex = -1;
                    txt_majordieases.Text = "";
                    txt_contactno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}




