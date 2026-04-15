namespace neri_studentregistration
{
    partial class StudentRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            firstnameBox = new TextBox();
            lastnameBox = new TextBox();
            miBox = new TextBox();
            addressBox = new TextBox();
            yearBox = new TextBox();
            birthdateBox = new DateTimePicker();
            label7 = new Label();
            genderBox = new ComboBox();
            label5 = new Label();
            courseBox = new ComboBox();
            imageButton = new Button();
            SaveButton = new Button();
            backButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 23F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 31);
            label2.Name = "label2";
            label2.Size = new Size(324, 39);
            label2.TabIndex = 1;
            label2.Text = "STUDENT REGISTRATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 88);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(174, 272);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 212);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(41, 145);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 7;
            label8.Text = "Birthdate:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(507, 88);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 8;
            label9.Text = "Middle Initial:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.White;
            label10.Location = new Point(44, 138);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(281, 88);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 10;
            label11.Text = "Last Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(477, 145);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 11;
            label12.Text = "Image:";
            // 
            // firstnameBox
            // 
            firstnameBox.Location = new Point(41, 114);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(220, 23);
            firstnameBox.TabIndex = 13;
            firstnameBox.TextChanged += firstnameBox_TextChanged;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(281, 114);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(200, 23);
            lastnameBox.TabIndex = 14;
            lastnameBox.TextChanged += lastnameBox_TextChanged;
            // 
            // miBox
            // 
            miBox.Location = new Point(507, 114);
            miBox.Name = "miBox";
            miBox.Size = new Size(220, 23);
            miBox.TabIndex = 15;
            miBox.TextChanged += miBox_TextChanged;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(44, 235);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(407, 23);
            addressBox.TabIndex = 18;
            addressBox.TextChanged += addressBox_TextChanged;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(174, 295);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(112, 23);
            yearBox.TabIndex = 20;
            yearBox.TextChanged += yearBox_TextChanged;
            // 
            // birthdateBox
            // 
            birthdateBox.Location = new Point(41, 174);
            birthdateBox.Name = "birthdateBox";
            birthdateBox.Size = new Size(220, 23);
            birthdateBox.TabIndex = 22;
            birthdateBox.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            birthdateBox.ValueChanged += birthdateBox_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(281, 145);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // genderBox
            // 
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(281, 173);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(185, 23);
            genderBox.TabIndex = 24;
            genderBox.SelectedIndexChanged += genderBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 272);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Course:";
            // 
            // courseBox
            // 
            courseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            courseBox.FormattingEnabled = true;
            courseBox.Items.AddRange(new object[] { "BSIT", "BSTM", "BSME", "TVET" });
            courseBox.Location = new Point(44, 295);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(99, 23);
            courseBox.TabIndex = 24;
            courseBox.SelectedIndexChanged += courseBox_SelectedIndexChanged;
            // 
            // imageButton
            // 
            imageButton.BackColor = Color.DarkGray;
            imageButton.Location = new Point(480, 174);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(67, 26);
            imageButton.TabIndex = 25;
            imageButton.Text = "browse...";
            imageButton.UseVisualStyleBackColor = false;
            imageButton.Click += imageButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Teal;
            SaveButton.Font = new Font("Impact", 11F);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(646, 340);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(81, 29);
            SaveButton.TabIndex = 26;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.DarkSlateGray;
            backButton.Font = new Font("Impact", 11F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(40, 340);
            backButton.Name = "backButton";
            backButton.Size = new Size(81, 29);
            backButton.TabIndex = 27;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(553, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 163);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DB_Manda___SS___Featured_Image_2__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 399);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            Controls.Add(SaveButton);
            Controls.Add(imageButton);
            Controls.Add(courseBox);
            Controls.Add(genderBox);
            Controls.Add(birthdateBox);
            Controls.Add(yearBox);
            Controls.Add(addressBox);
            Controls.Add(miBox);
            Controls.Add(lastnameBox);
            Controls.Add(firstnameBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Load += StudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox firstnameBox;
        private TextBox lastnameBox;
        private TextBox miBox;
        private TextBox addressBox;
        private TextBox yearBox;
        private DateTimePicker birthdateBox;
        private Label label7;
        private ComboBox genderBox;
        private Label label5;
        private ComboBox courseBox;
        private Button imageButton;
		private Button SaveButton;
		private Button button2;
		private Button backButton;
		private PictureBox pictureBox1;
    }
}
