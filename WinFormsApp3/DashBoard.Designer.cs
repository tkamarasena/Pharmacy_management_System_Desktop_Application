namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Patient = new Button();
            btn_Doctor = new Button();
            btn_Prescripition = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_logout = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btn_Patient
            // 
            btn_Patient.Cursor = Cursors.Hand;
            btn_Patient.Location = new Point(425, 162);
            btn_Patient.Name = "btn_Patient";
            btn_Patient.Size = new Size(75, 28);
            btn_Patient.TabIndex = 0;
            btn_Patient.Text = "Patient";
            btn_Patient.UseVisualStyleBackColor = true;
            btn_Patient.Click += button1_Click;
            // 
            // btn_Doctor
            // 
            btn_Doctor.Cursor = Cursors.Hand;
            btn_Doctor.Location = new Point(425, 268);
            btn_Doctor.Name = "btn_Doctor";
            btn_Doctor.Size = new Size(75, 28);
            btn_Doctor.TabIndex = 1;
            btn_Doctor.Text = "Doctor";
            btn_Doctor.UseVisualStyleBackColor = true;
            btn_Doctor.Click += btn_Doctor_Click;
            // 
            // btn_Prescripition
            // 
            btn_Prescripition.Cursor = Cursors.Hand;
            btn_Prescripition.Location = new Point(425, 387);
            btn_Prescripition.Name = "btn_Prescripition";
            btn_Prescripition.Size = new Size(75, 28);
            btn_Prescripition.TabIndex = 2;
            btn_Prescripition.Text = "Pescription";
            btn_Prescripition.UseVisualStyleBackColor = true;
            btn_Prescripition.Click += btn_Prescripition_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 356);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(302, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(302, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.BackgroundImage = (Image)resources.GetObject("btn_logout.BackgroundImage");
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(721, 80);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(75, 28);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "LOGOUT";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 56);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 9);
            label2.Name = "label2";
            label2.Size = new Size(331, 37);
            label2.TabIndex = 11;
            label2.Text = "MADHURA DISPENSARY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 13);
            panel2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(695, 80);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 495);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_logout);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Prescripition);
            Controls.Add(btn_Doctor);
            Controls.Add(btn_Patient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Patient;
        private Button btn_Doctor;
        private Button btn_Prescripition;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_logout;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox4;
    }
}