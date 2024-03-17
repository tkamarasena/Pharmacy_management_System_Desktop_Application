namespace WinFormsApp3
{
    partial class Prescripttion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescripttion));
            pictureBox1 = new PictureBox();
            btn_EDIT = new Button();
            btn_ADD = new Button();
            lbl_Experiences = new Label();
            txt_PrescripitionTest = new TextBox();
            txt_Symptoms = new TextBox();
            txt_medicines = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            rtbMedicine = new RichTextBox();
            rtbTest = new RichTextBox();
            lblPatientName = new Label();
            lblPressId = new Label();
            groupBox2 = new GroupBox();
            cmbPatientId = new ComboBox();
            txtPatientName = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_EDIT
            // 
            btn_EDIT.BackColor = Color.FromArgb(255, 255, 128);
            btn_EDIT.Cursor = Cursors.Hand;
            btn_EDIT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EDIT.Location = new Point(477, 453);
            btn_EDIT.Name = "btn_EDIT";
            btn_EDIT.Size = new Size(75, 28);
            btn_EDIT.TabIndex = 22;
            btn_EDIT.Text = "EDIT";
            btn_EDIT.UseVisualStyleBackColor = false;
            btn_EDIT.Click += btn_EDIT_Click_1;
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.FromArgb(255, 255, 128);
            btn_ADD.Cursor = Cursors.Hand;
            btn_ADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ADD.Location = new Point(373, 453);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(75, 28);
            btn_ADD.TabIndex = 21;
            btn_ADD.Text = "ADD";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += btn_ADD_Click_1;
            // 
            // lbl_Experiences
            // 
            lbl_Experiences.AutoSize = true;
            lbl_Experiences.Location = new Point(315, 121);
            lbl_Experiences.Name = "lbl_Experiences";
            lbl_Experiences.Size = new Size(64, 15);
            lbl_Experiences.TabIndex = 36;
            lbl_Experiences.Text = "Symptoms";
            // 
            // txt_PrescripitionTest
            // 
            txt_PrescripitionTest.BackColor = SystemColors.Window;
            txt_PrescripitionTest.Location = new Point(411, 157);
            txt_PrescripitionTest.Name = "txt_PrescripitionTest";
            txt_PrescripitionTest.Size = new Size(141, 23);
            txt_PrescripitionTest.TabIndex = 34;
            // 
            // txt_Symptoms
            // 
            txt_Symptoms.BackColor = SystemColors.Window;
            txt_Symptoms.Location = new Point(411, 118);
            txt_Symptoms.Name = "txt_Symptoms";
            txt_Symptoms.Size = new Size(141, 23);
            txt_Symptoms.TabIndex = 33;
            // 
            // txt_medicines
            // 
            txt_medicines.BackColor = SystemColors.Window;
            txt_medicines.Location = new Point(411, 192);
            txt_medicines.Name = "txt_medicines";
            txt_medicines.Size = new Size(141, 23);
            txt_medicines.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 160);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 39;
            label1.Text = "Diagnostic Test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 195);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 40;
            label2.Text = "Medicines";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(504, 194);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 39);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 45;
            label4.Text = "Prescripition ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(213, 39);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 46;
            label5.Text = "Patient Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 180);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 47;
            label6.Text = "Prescription Test";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 180);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 48;
            label7.Text = "Medicines";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 43);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 49;
            label8.Text = "Patient ID";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(286, 353);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 51;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(116, 23);
            label9.Name = "label9";
            label9.Size = new Size(143, 30);
            label9.TabIndex = 52;
            label9.Text = "Prescripition ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbMedicine);
            groupBox1.Controls.Add(rtbTest);
            groupBox1.Controls.Add(lblPatientName);
            groupBox1.Controls.Add(lblPressId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(630, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 387);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prescripition Summary";
            // 
            // rtbMedicine
            // 
            rtbMedicine.BackColor = SystemColors.ActiveCaption;
            rtbMedicine.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtbMedicine.Location = new Point(203, 198);
            rtbMedicine.Name = "rtbMedicine";
            rtbMedicine.Size = new Size(158, 131);
            rtbMedicine.TabIndex = 55;
            rtbMedicine.Text = "";
            // 
            // rtbTest
            // 
            rtbTest.BackColor = SystemColors.ActiveCaption;
            rtbTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtbTest.Location = new Point(32, 198);
            rtbTest.Name = "rtbTest";
            rtbTest.Size = new Size(158, 131);
            rtbTest.TabIndex = 54;
            rtbTest.Text = "";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientName.Location = new Point(228, 81);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(64, 25);
            lblPatientName.TabIndex = 53;
            lblPatientName.Text = "Name";
            // 
            // lblPressId
            // 
            lblPressId.AutoSize = true;
            lblPressId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPressId.Location = new Point(62, 81);
            lblPressId.Name = "lblPressId";
            lblPressId.Size = new Size(32, 25);
            lblPressId.TabIndex = 52;
            lblPressId.Text = "ID";
            lblPressId.Click += label10_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbPatientId);
            groupBox2.Controls.Add(txtPatientName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btn_EDIT);
            groupBox2.Controls.Add(btn_ADD);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lbl_Experiences);
            groupBox2.Controls.Add(txt_Symptoms);
            groupBox2.Controls.Add(txt_PrescripitionTest);
            groupBox2.Controls.Add(txt_medicines);
            groupBox2.Location = new Point(12, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(602, 500);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prescripition";
            // 
            // cmbPatientId
            // 
            cmbPatientId.FormattingEnabled = true;
            cmbPatientId.Location = new Point(411, 40);
            cmbPatientId.Name = "cmbPatientId";
            cmbPatientId.Size = new Size(141, 23);
            cmbPatientId.TabIndex = 53;
            cmbPatientId.SelectionChangeCommitted += cmbPatientId_SelectionChangeCommitted;
            // 
            // txtPatientName
            // 
            txtPatientName.BackColor = SystemColors.Window;
            txtPatientName.Location = new Point(411, 78);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(141, 23);
            txtPatientName.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 81);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 51;
            label3.Text = "Patient Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.R;
            pictureBox2.Location = new Point(60, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Prescripttion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1012, 596);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prescripttion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prescripttion";
            Load += Prescripttion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_EDIT;
        private Button btn_ADD;
        private Label lbl_Experiences;
        private TextBox txt_PrescripitionTest;
        private TextBox txt_Symptoms;
        private TextBox txt_medicines;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private TextBox txtPatientName;
        private Label label3;
        private ComboBox cmbPatientId;
        private Label lblPressId;
        private Label lblPatientName;
        private RichTextBox rtbMedicine;
        private RichTextBox rtbTest;
    }
}