namespace WinFormsApp3
{
    partial class ptientsymptoms
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
            button2 = new Button();
            btn_ADD = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(584, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 22;
            button2.Text = "Proceed";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.FromArgb(255, 255, 128);
            btn_ADD.Location = new Point(584, 535);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(75, 28);
            btn_ADD.TabIndex = 21;
            btn_ADD.Text = "ADD";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += btn_ADD_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 137);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 19;
            label3.Text = "Mediaction";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 137);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 17;
            label1.Text = "Patient ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(459, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 248);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 24;
            label4.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(459, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 190);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 26;
            label6.Text = "Date";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(33, 310);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(626, 190);
            dataGridView2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(459, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 248);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 31;
            label5.Text = "Dosage";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(33, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(78, 29);
            label9.Name = "label9";
            label9.Size = new Size(191, 30);
            label9.TabIndex = 33;
            label9.Text = "Patient Symptoms";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 190);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 18;
            label2.Text = "Symptom";
            // 
            // ptientsymptoms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(692, 596);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(btn_ADD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ptientsymptoms";
            Text = "ptientsymptoms";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btn_ADD;
        private Label label3;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label6;
        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label2;
    }
}