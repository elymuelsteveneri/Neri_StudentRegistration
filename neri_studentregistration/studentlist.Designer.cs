namespace neri_studentregistration
{
    partial class studentlist
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
			viewstudents = new DataGridView();
			backButton = new Button();
			((System.ComponentModel.ISupportInitialize)viewstudents).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Impact", 25F);
			label1.ForeColor = Color.FromArgb(224, 224, 224);
			label1.Location = new Point(29, 9);
			label1.Name = "label1";
			label1.Size = new Size(201, 42);
			label1.TabIndex = 1;
			label1.Text = "STUDENT LIST";
			// 
			// viewstudents
			// 
			viewstudents.AllowUserToAddRows = false;
			viewstudents.AllowUserToDeleteRows = false;
			viewstudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			viewstudents.BackgroundColor = Color.WhiteSmoke;
			viewstudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			viewstudents.Location = new Point(38, 65);
			viewstudents.Name = "viewstudents";
			viewstudents.ReadOnly = true;
			viewstudents.Size = new Size(593, 348);
			viewstudents.TabIndex = 2;
			viewstudents.CellContentClick += viewstudents_CellContentClick;
			viewstudents.CellDoubleClick += viewstudents_CellDoubleClick;
			// 
			// backButton
			// 
			backButton.Location = new Point(29, 433);
			backButton.Name = "backButton";
			backButton.Size = new Size(60, 21);
			backButton.TabIndex = 3;
			backButton.Text = "Back";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += button1_Click;
			// 
			// studentlist
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			BackgroundImage = Properties.Resources.DB_Manda___SS___Featured_Image_2__1_;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(771, 490);
			Controls.Add(backButton);
			Controls.Add(viewstudents);
			Controls.Add(label1);
			Name = "studentlist";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "studentlist";
			Load += studentlist_Load;
			((System.ComponentModel.ISupportInitialize)viewstudents).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private DataGridView viewstudents;
        private Button backButton;
	}
}