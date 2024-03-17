namespace WinFormsApp3
{
    partial class patienrtdetails
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
            txt_patientName = new TextBox();
            txt_contactno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btn_ADD = new Button();
            button2 = new Button();
            btn_EDIT = new Button();
            btn_Delete = new Button();
            label5 = new Label();
            txt_age = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt_majordieases = new TextBox();
            combo_bloodgroup = new ComboBox();
            combo_gender = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_patientName
            // 
            txt_patientName.Location = new Point(314, 118);
            txt_patientName.Name = "txt_patientName";
            txt_patientName.Size = new Size(278, 23);
            txt_patientName.TabIndex = 1;
            // 
            // txt_contactno
            // 
            txt_contactno.Location = new Point(314, 159);
            txt_contactno.Name = "txt_contactno";
            txt_contactno.Size = new Size(278, 23);
            txt_contactno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 121);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 162);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 6;
            label3.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 215);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(613, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.FromArgb(255, 255, 128);
            btn_ADD.Cursor = Cursors.Hand;
            btn_ADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ADD.Location = new Point(351, 547);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(75, 28);
            btn_ADD.TabIndex = 12;
            btn_ADD.Text = "ADD";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += btn_ADD_Click;
            // 
            // button2
            // 
            button2.Location = new Point(513, 39);
            button2.Name = "button2";
            button2.Size = new Size(154, 23);
            button2.TabIndex = 13;
            button2.Text = "Patient Symptoms";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_EDIT
            // 
            btn_EDIT.BackColor = Color.FromArgb(255, 255, 128);
            btn_EDIT.Cursor = Cursors.Hand;
            btn_EDIT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EDIT.Location = new Point(464, 547);
            btn_EDIT.Name = "btn_EDIT";
            btn_EDIT.Size = new Size(75, 28);
            btn_EDIT.TabIndex = 14;
            btn_EDIT.Text = "EDIT";
            btn_EDIT.UseVisualStyleBackColor = false;
            btn_EDIT.Click += btn_EDIT_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 255, 128);
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.Location = new Point(579, 547);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 28);
            btn_Delete.TabIndex = 15;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 215);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 20;
            label5.Text = "Age";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(492, 207);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(100, 23);
            txt_age.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 261);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 22;
            label6.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 307);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 24;
            label7.Text = "Major Dieases";
            // 
            // txt_majordieases
            // 
            txt_majordieases.Location = new Point(314, 307);
            txt_majordieases.Name = "txt_majordieases";
            txt_majordieases.Size = new Size(278, 23);
            txt_majordieases.TabIndex = 25;
            // 
            // combo_bloodgroup
            // 
            combo_bloodgroup.FormattingEnabled = true;
            combo_bloodgroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-" });
            combo_bloodgroup.Location = new Point(314, 258);
            combo_bloodgroup.Name = "combo_bloodgroup";
            combo_bloodgroup.Size = new Size(121, 23);
            combo_bloodgroup.TabIndex = 26;
            // 
            // combo_gender
            // 
            combo_gender.FormattingEnabled = true;
            combo_gender.Items.AddRange(new object[] { "Male", "Female" });
            combo_gender.Location = new Point(314, 207);
            combo_gender.Name = "combo_gender";
            combo_gender.Size = new Size(100, 23);
            combo_gender.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 31);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(86, 31);
            label9.Name = "label9";
            label9.Size = new Size(154, 30);
            label9.TabIndex = 29;
            label9.Text = "Patient Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(41, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // patienrtdetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(692, 596);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(combo_gender);
            Controls.Add(combo_bloodgroup);
            Controls.Add(txt_majordieases);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_age);
            Controls.Add(label5);
            Controls.Add(btn_Delete);
            Controls.Add(btn_EDIT);
            Controls.Add(button2);
            Controls.Add(btn_ADD);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_contactno);
            Controls.Add(txt_patientName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "patienrtdetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "patienrtdetails";
            Load += patienrtdetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_patientName;
        private TextBox txt_contactno;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btn_ADD;
        private Button button2;
        private Button btn_EDIT;
        private Button btn_Delete;
        private Label label5;
        private TextBox txt_age;
        private Label label6;
        private Label label7;
        private TextBox txt_majordieases;
        private ComboBox combo_bloodgroup;
        private ComboBox combo_gender;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
    }
}