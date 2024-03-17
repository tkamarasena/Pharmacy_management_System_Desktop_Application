namespace WinFormsApp3
{
    partial class doctor
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
            btn_DELETE = new Button();
            btn_EDIT = new Button();
            btn_ADD = new Button();
            txt_docName = new TextBox();
            txt_exYears = new TextBox();
            txt_MLNo = new TextBox();
            txt_CNo = new TextBox();
            lbl_DoctorName = new Label();
            lbl_Experiences = new Label();
            lbl_LiciencesNumber = new Label();
            lbl_ContactNo = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_DELETE
            // 
            btn_DELETE.BackColor = Color.FromArgb(255, 255, 128);
            btn_DELETE.Cursor = Cursors.Hand;
            btn_DELETE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DELETE.Location = new Point(569, 528);
            btn_DELETE.Name = "btn_DELETE";
            btn_DELETE.Size = new Size(75, 28);
            btn_DELETE.TabIndex = 19;
            btn_DELETE.Text = "DELETE";
            btn_DELETE.UseVisualStyleBackColor = false;
            btn_DELETE.Click += btn_DELETE_Click;
            // 
            // btn_EDIT
            // 
            btn_EDIT.BackColor = Color.FromArgb(255, 255, 128);
            btn_EDIT.Cursor = Cursors.Hand;
            btn_EDIT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EDIT.Location = new Point(464, 528);
            btn_EDIT.Name = "btn_EDIT";
            btn_EDIT.Size = new Size(75, 28);
            btn_EDIT.TabIndex = 18;
            btn_EDIT.Text = "EDIT";
            btn_EDIT.UseVisualStyleBackColor = false;
            btn_EDIT.Click += btn_EDIT_Click;
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.FromArgb(255, 255, 128);
            btn_ADD.Cursor = Cursors.Hand;
            btn_ADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ADD.Location = new Point(351, 528);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(75, 28);
            btn_ADD.TabIndex = 17;
            btn_ADD.Text = "ADD";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += btn_ADD_Click;
            // 
            // txt_docName
            // 
            txt_docName.Location = new Point(327, 144);
            txt_docName.Name = "txt_docName";
            txt_docName.Size = new Size(256, 23);
            txt_docName.TabIndex = 22;
            // 
            // txt_exYears
            // 
            txt_exYears.Location = new Point(327, 192);
            txt_exYears.Name = "txt_exYears";
            txt_exYears.Size = new Size(256, 23);
            txt_exYears.TabIndex = 23;
            // 
            // txt_MLNo
            // 
            txt_MLNo.Location = new Point(327, 242);
            txt_MLNo.Name = "txt_MLNo";
            txt_MLNo.Size = new Size(256, 23);
            txt_MLNo.TabIndex = 24;
            // 
            // txt_CNo
            // 
            txt_CNo.Location = new Point(327, 292);
            txt_CNo.Name = "txt_CNo";
            txt_CNo.Size = new Size(256, 23);
            txt_CNo.TabIndex = 25;
            // 
            // lbl_DoctorName
            // 
            lbl_DoctorName.AutoSize = true;
            lbl_DoctorName.Location = new Point(231, 147);
            lbl_DoctorName.Name = "lbl_DoctorName";
            lbl_DoctorName.Size = new Size(78, 15);
            lbl_DoctorName.TabIndex = 27;
            lbl_DoctorName.Text = "Doctor Name";
            // 
            // lbl_Experiences
            // 
            lbl_Experiences.AutoSize = true;
            lbl_Experiences.Location = new Point(201, 195);
            lbl_Experiences.Name = "lbl_Experiences";
            lbl_Experiences.Size = new Size(108, 15);
            lbl_Experiences.TabIndex = 28;
            lbl_Experiences.Text = "Years of Experience";
            // 
            // lbl_LiciencesNumber
            // 
            lbl_LiciencesNumber.AutoSize = true;
            lbl_LiciencesNumber.Location = new Point(170, 245);
            lbl_LiciencesNumber.Name = "lbl_LiciencesNumber";
            lbl_LiciencesNumber.Size = new Size(142, 15);
            lbl_LiciencesNumber.TabIndex = 29;
            lbl_LiciencesNumber.Text = "Medical Licience Number";
            // 
            // lbl_ContactNo
            // 
            lbl_ContactNo.AutoSize = true;
            lbl_ContactNo.Location = new Point(213, 295);
            lbl_ContactNo.Name = "lbl_ContactNo";
            lbl_ContactNo.Size = new Size(96, 15);
            lbl_ContactNo.TabIndex = 30;
            lbl_ContactNo.Text = "Contact Number";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 345);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(613, 150);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 37);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 34;
            label1.Text = "Doctor";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(31, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 596);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_ContactNo);
            Controls.Add(lbl_LiciencesNumber);
            Controls.Add(lbl_Experiences);
            Controls.Add(lbl_DoctorName);
            Controls.Add(txt_CNo);
            Controls.Add(txt_MLNo);
            Controls.Add(txt_exYears);
            Controls.Add(txt_docName);
            Controls.Add(btn_DELETE);
            Controls.Add(btn_EDIT);
            Controls.Add(btn_ADD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "doctor";
            Load += doctor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_DELETE;
        private Button btn_EDIT;
        private Button btn_ADD;
        private TextBox txt_docName;
        private TextBox txt_exYears;
        private TextBox txt_MLNo;
        private TextBox txt_CNo;
        private Label lbl_DoctorName;
        private Label lbl_Experiences;
        private Label lbl_LiciencesNumber;
        private Label lbl_ContactNo;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}