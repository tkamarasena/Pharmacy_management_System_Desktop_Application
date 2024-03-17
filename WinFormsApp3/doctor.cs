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
    public partial class doctor : Form
    {
        Functions Con;
        public doctor()
        {
            InitializeComponent();
            Con = new Functions();
        }





        private void ShowDoctor()
        {
            try
            {
                txt_docName.Focus();
                string Query = "SELECT * FROM Doctor";
                dataGridView1.DataSource = Con.GetData(Query);
            }
            catch
            {

                throw;
            }
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_docName.Text == "" || txt_CNo.Text == "" || txt_MLNo.Text == "" || txt_exYears.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string name = txt_docName.Text;
                    int experiance = Convert.ToInt32(txt_exYears.Text);
                    string mlc = txt_MLNo.Text;
                    string phone = txt_CNo.Text;



                    string Query = "INSERT INTO  Doctor VALUES('{0}','{1}',{2},'{3}')";
                    Query = string.Format(Query, name, phone, experiance, mlc);
                    Con.SetData(Query);
                    ShowDoctor();
                    MessageBox.Show("Doctor data is Added!!");
                    txt_docName.Text = "";
                    txt_CNo.Text = "";
                    txt_exYears.Text = "";
                    txt_MLNo.Text = "";
                    txt_docName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowdataGridView1()
        {
            string connectionString = "Data Source=DESKTOP-4MUG21C;Initial Catalog=pms;Integrated Security=True";
            string query = "SELECT * FROM doctors";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable doctorsTable = new DataTable();
                adapter.Fill(doctorsTable);

                dataGridView1.DataSource = doctorsTable;
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            ShowDoctor();
        }

        private void btn_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_docName.Text == "" || txt_exYears.Text == "" || txt_MLNo.Text == "" || txt_CNo.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string name = txt_docName.Text;
                    int experiance = Convert.ToInt32(txt_exYears.Text);
                    string phone = txt_CNo.Text;
                    string license = txt_MLNo.Text;


                    string Query = "UPDATE  Doctor SET Name='{0}', Contact='{1}', Experience='{2}', Licensce='{3}' WHERE DocId={4}";
                    Query = string.Format(Query, name, phone, experiance, license, key+1);
                    Con.SetData(Query);
                    ShowDoctor();
                    MessageBox.Show("Details are updated!!");
                    txt_docName.Text = "";
                    txt_exYears.Text = "";
                    txt_MLNo.Text = "";
                    txt_CNo.Text = "";
                    txt_docName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("" + key);
                if (txt_docName.Text=="")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    
                    string Query = "DELETE FROM Doctor WHERE DocId = {0}";
                    Query = string.Format(Query, key + 1);
                    Con.SetData(Query);
                    ShowDoctor();
                    MessageBox.Show("Doctor Is Deleted!!");
                    txt_docName.Text = "";
                    txt_exYears.Text = "";
                    txt_CNo.Text = "";
                    txt_MLNo.Text = "";
                    txt_docName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearDoctorTextBoxes()
        {
            throw new NotImplementedException();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        int key;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[key];
            txt_docName.Text = row.Cells[1].Value.ToString();
            txt_CNo.Text = row.Cells[2].Value.ToString();
            txt_exYears.Text = row.Cells[3].Value.ToString();
            txt_MLNo.Text = row.Cells[4].Value.ToString();

        }
    }
}


