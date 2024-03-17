namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patienrtdetails patient = new patienrtdetails();
            patient.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginadmin log = new loginadmin();
            log.Show();
            this.Close();
        }

        private void btn_Prescripition_Click(object sender, EventArgs e)
        {
           
            Prescripttion pres = new Prescripttion();
            pres.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {


            doctor doctor = new doctor();
            doctor.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loginadmin log = new loginadmin();
            log.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}