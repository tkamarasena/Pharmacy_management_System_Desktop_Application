namespace WinFormsApp3
{
    partial class loginadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginadmin));
            lbl_username = new Label();
            lbl_password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_submit = new Button();
            pictureBox1 = new PictureBox();
            checkBox = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Black;
            lbl_username.Location = new Point(395, 227);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(94, 21);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "User Name";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.Location = new Point(407, 297);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(82, 21);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(507, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(507, 295);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            // 
            // btn_submit
            // 
            btn_submit.Cursor = Cursors.Hand;
            btn_submit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.Location = new Point(575, 378);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(109, 32);
            btn_submit.TabIndex = 4;
            btn_submit.Text = "LOGIN";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
            checkBox.Location = new Point(576, 324);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(108, 19);
            checkBox.TabIndex = 6;
            checkBox.Text = "Show Password";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(443, 84);
            label1.Name = "label1";
            label1.Size = new Size(242, 21);
            label1.TabIndex = 8;
            label1.Text = "Dr.A.M.Sadaruwan Disanayaka";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(440, 378);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 9;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 33);
            label2.Name = "label2";
            label2.Size = new Size(469, 37);
            label2.TabIndex = 10;
            label2.Text = "WELCOME MADHURA DISPENSARY";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(881, 536);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox);
            Controls.Add(pictureBox1);
            Controls.Add(btn_submit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "loginadmin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private Label lbl_password;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_submit;
        private PictureBox pictureBox1;
        private CheckBox checkBox;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}