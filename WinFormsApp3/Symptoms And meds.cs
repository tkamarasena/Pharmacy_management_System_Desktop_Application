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

namespace WinFormsApp3
{
    public partial class ptientsymptoms : Form
    {

        public ptientsymptoms(int patientID)
        {
            InitializeComponent();
            textBox1.Text = patientID.ToString();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True");
        private void Displayptientsmptoms()
        {
            try
            {
                con.Open();
                string Query = "select * from Medication";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void PatientSymptomsMedsForm_Load(object sender, EventArgs e)
        {




        }


        private void ptientsymptoms_Load(object sender, EventArgs e)
        {

        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string dosage = textBox5.Text;
            int patientID = Convert.ToInt32(textBox1.Text);
            string medication = textBox2.Text;
            string symptom = textBox3.Text;
            DateTime date = dateTimePicker1.Value;
            decimal price = Convert.ToDecimal(textBox4.Text);
            string connectionString = "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True";

            string query = "INSERT INTO Medication (PatientID, MedicationName, Dosage, Symptoms,MedicationDate, Price ) VALUES (@PatientID, @MedicationName, @dosage,@symptoms, @date, @price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MedicationName", medication);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@symptoms", symptom);
                command.Parameters.AddWithValue("@dosage", dosage);



                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Show data in DataGridView after adding
                    ShowDataInGridView();

                    // Open Symptoms and Medications Form


                    // Optionally, close or hide this form
                    // this.Close(); 
                    // OR
                    // this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void ShowDataInGridView()
        {
            string connectionString = "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True";
            string query = "SELECT * FROM Medication";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable patientsTable = new DataTable();
                adapter.Fill(patientsTable);

                dataGridView2.DataSource = patientsTable;
            }
        }
        private void btn_ADD_Click_1(object sender, EventArgs e)
        {
            string dosage = textBox5.Text;
            int patientID = Convert.ToInt32(textBox1.Text);
            string medication = textBox2.Text;
            string symptom = textBox3.Text;
            DateTime date = dateTimePicker1.Value;

            MessageBox.Show("Price entered: " + textBox4.Text); // Temporary line to display the value

            if (int.TryParse(textBox4.Text, out int price))
            {
                string connectionString = "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True";
                string query = "INSERT INTO Medication (PatientID, MedicationName, Dosage, Symptoms, MedicationDate, Price) VALUES (@PatientID, @MedicationName, @dosage, @symptoms, @date, @price)";

                // Remaining code unchanged...



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MedicationName", medication);
                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@symptoms", symptom);
                    command.Parameters.AddWithValue("@dosage", dosage);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        ShowDataInGridView(); // Show data in DataGridView after adding

                        // Optionally, close or hide this form
                        // this.Close(); 
                        // OR
                        // this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for price.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Prescripttion prescription = new Prescripttion();
            prescription.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }
    }
}

