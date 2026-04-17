namespace neri_studentregistration
{
    partial class Home
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 80F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(195, 53);
            label1.Name = "label1";
            label1.Size = new Size(1628, 132);
            label1.TabIndex = 0;
            label1.Text = "DON BOSCO TECHNICAL COLLEGE-CEBU";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.b54fc0fc3bd8a5775a08061ee30843a1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.White;
            button1.Location = new Point(787, 459);
            button1.Name = "button1";
            button1.Size = new Size(219, 222);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.images1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1087, 466);
            button2.Name = "button2";
            button2.Size = new Size(206, 209);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 25F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(708, 298);
            label2.Name = "label2";
            label2.Size = new Size(676, 78);
            label2.TabIndex = 3;
            label2.Text = "STUDENT REGISTRATION HOME PAGE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(787, 694);
            label3.Name = "label3";
            label3.Size = new Size(215, 36);
            label3.TabIndex = 4;
            label3.Text = "ADD STUDENT";
            label3.DockChanged += Home_Load;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSeaGreen;
            label4.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(1083, 694);
            label4.Name = "label4";
            label4.Size = new Size(210, 36);
            label4.TabIndex = 5;
            label4.Text = "STUDENT LIST";
            label4.DockChanged += Home_Load;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DB_Manda___SS___Featured_Image_2__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}