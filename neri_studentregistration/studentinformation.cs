using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neri_studentregistration
{
	public partial class studentinformation : Form

	{
		private Student _student;

		public studentinformation(Student student)
		{
			InitializeComponent();
			_student = student;
		}


		private void studentinformation_Load(object? sender, EventArgs e)
		{

			{
				label8.Text = $"{_student.FirstName} {_student.MiddleInitial} {_student.LastName}";
				label9.Text = _student.Course;
				label11.Text = _student.Gender;
				label12.Text = _student.Address;
				label13.Text = _student.Year;
				pictureBox1.BackgroundImage = Image.FromFile(_student.StudentImage!);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

				label10.Text = $"{CalculatedAge(_student.Birthdate)}";
            }


		}

		private int CalculatedAge (DateTime birthdateBox)
		{
			int age = DateTime.Now.Year - birthdateBox.Year;

			if (DateTime.Now < birthdateBox.AddYears(age))
				age--;

			return age;
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			StudentRegistration editForm = new StudentRegistration(_student);
			editForm.ShowDialog();

			this.Close();
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
