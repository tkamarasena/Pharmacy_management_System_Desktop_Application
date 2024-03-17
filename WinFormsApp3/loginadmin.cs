using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class loginadmin : Form
    {
        public loginadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin" && textBox2.Text.Trim() == "123")
            {
                Form1 form1 = new Form1(); // Create an instance of Form1
                form1.Show(); // Show Form1 if the condition is met
                this.Hide(); // Hide the current form (assuming you want to hide it)
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please enter the correct values."); // Show a message if credentials are incorrect
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                textBox2.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox2.PasswordChar = '*'; // Hide password
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
