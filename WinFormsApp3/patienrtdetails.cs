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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace WinFormsApp3
{
    public partial class patienrtdetails : Form
    {
        Functions Con;
        public patienrtdetails()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void ShowPatients()
        {
            try
            {
                txt_patientName.Focus();
                string Query = "SELECT * FROM Patient";
                dataGridView1.DataSource = Con.GetData(Query);
            }
            catch
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_patientName.Text == "" || txt_age.Text == "" || combo_gender.SelectedIndex == -1 || combo_bloodgroup.SelectedIndex == -1
                    || txt_contactno.Text == "" || txt_majordieases.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string name = txt_patientName.Text;
                    int age = Convert.ToInt32(txt_age.Text);
                    string gender = combo_gender.GetItemText(combo_gender.SelectedItem);
                    string blood = combo_gender.GetItemText(combo_bloodgroup.SelectedItem);
                    string phone = txt_contactno.Text;
                    string diseases = txt_majordieases.Text;


                    string Query = "INSERT INTO  Patient VALUES('{0}',{1},'{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, name, age, gender, blood, phone, diseases);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Patient data is Updated!!");
                    txt_patientName.Text = "";
                    txt_age.Text = "";
                    combo_gender.SelectedIndex = -1;
                    txt_contactno.Text = "";
                    combo_bloodgroup.SelectedIndex = -1;
                    txt_majordieases.Text = "";
                    txt_patientName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void ShowDataInGridView()
        {
            string connectionString = "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True";
            string query = "SELECT * FROM Patients";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable patientsTable = new DataTable();
                adapter.Fill(patientsTable);

                dataGridView1.DataSource = patientsTable;
            }
        }*/

        private void btn_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_patientName.Text == "" || txt_age.Text == "" || combo_gender.SelectedIndex == -1 || combo_bloodgroup.SelectedIndex == -1
                    || txt_contactno.Text == "" || txt_majordieases.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string name = txt_patientName.Text;
                    int age = Convert.ToInt32(txt_age.Text);
                    string gender = combo_gender.GetItemText(combo_gender.SelectedItem.ToString());
                    string blood = combo_gender.GetItemText(combo_bloodgroup.SelectedItem.ToString());
                    string phone = txt_contactno.Text;
                    string diseases = txt_majordieases.Text;


                    string Query = "UPDATE  Patient SET PatientName='{0}', Age={1}, Gender='{2}', Blood='{3}', Phone='{4}', Diseases='{5}' WHERE PatientId={6}";
                    Query = string.Format(Query, name, age, gender, blood, phone, diseases, key+1);
                    Con.SetData(Query);
                    ShowPatients();
                    MessageBox.Show("Details are updated!!");
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
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {

                    string Query = "DELETE FROM Patient WHERE PatientId = {0}";
                    Query = string.Format(Query, key+1);
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
            }
        }


        // ... Existing code ...

        private void ClearPatientTextBoxes()
        {

            txt_patientName.Text = "";
            txt_contactno.Text = "";
            txt_age.Text = "";
            combo_gender.SelectedIndex = 0;
            txt_majordieases.Text = "";
            combo_bloodgroup.SelectedIndex = -1;
        }


        int key;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* txt_patientName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            combo_gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            combo_bloodgroup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_contactno.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_majordieases.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();



            if (txt_patientName.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }*/

            key= e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[key];
            txt_patientName.Text = row.Cells[1].Value.ToString();
            txt_age.Text = row.Cells[2].Value.ToString();
            combo_gender.Text = row.Cells[3].Value.ToString();
            combo_bloodgroup.Text = row.Cells[4].Value.ToString();
            txt_contactno.Text = row.Cells[5].Value.ToString();
            txt_majordieases.Text = row.Cells[6].Value.ToString();

            
        }

        // Other methods and event handlers

        // ... (Your existing code)

        #region Windows Form Designer generated code

        // ... (Your existing designer-generated code)

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void patienrtdetails_Load(object sender, EventArgs e)
        {
            ShowPatients();
        }
    }
}











