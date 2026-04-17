using System.Security.Cryptography;
using static neri_studentregistration.Program;

namespace neri_studentregistration
{
	public partial class StudentRegistration : Form
	{
		public static string ImagePath = "";
		public static Student? editStudent;
        public StudentRegistration(Student student)
		{
			InitializeComponent();
			editStudent = student;
		}
		private void StudentRegistration_Load(object sender, EventArgs e)
		{
			if (editStudent != null)
			{
				label2.Text = "EDIT STUDENT";
				firstnameBox.Text = editStudent!.FirstName;
				lastnameBox.Text = editStudent.LastName;
				courseBox.Text = editStudent.Course;
				yearBox.Text = editStudent.Year;
                genderBox.Text = editStudent.Gender;
                miBox.Text = editStudent.MiddleInitial.ToString();
				addressBox.Text = editStudent.Address;
				birthdateBox.Value = editStudent.Birthdate;
				pictureBox1.BackgroundImage = Image.FromFile(editStudent.StudentImage!);

			}

        }

		private void imageButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				ImagePath = ofd.FileName;

                pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
				pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			}
		}
		private void SaveButton_Click(object sender, EventArgs e)
		{
			 if (editStudent == null)
			{
				if (string.IsNullOrWhiteSpace(firstnameBox.Text) ||
					string.IsNullOrWhiteSpace(lastnameBox.Text))
				{
					MessageBox.Show("Please fill in required fields.");
					return;
				}

				Student student = new Student
				{
					FirstName = Capitalize(firstnameBox.Text),
					LastName = Capitalize(lastnameBox.Text),
					MiddleInitial = $"{Capitalize(miBox.Text)}",
					Birthdate = birthdateBox.Value,
                    Course = courseBox.Text,
                    Gender = genderBox.Text,
					Address = addressBox.Text,
					Year = yearBox.Text,
					StudentImage = ImagePath
				};

				Home.studentList.Add(student);

				Home.SaveToText();

				MessageBox.Show("Student saved!");

				studentlist listForm = new studentlist();

				this.Close();
				listForm.Show();

				ClearFields();
			 }
			else if (editStudent != null)
			{
				editStudent.FirstName = Capitalize(firstnameBox.Text);
				editStudent.LastName = Capitalize(lastnameBox.Text);
				editStudent.MiddleInitial = Capitalize(miBox.Text);
				editStudent.Birthdate = birthdateBox.Value;
				editStudent.Address = addressBox.Text;
				editStudent.Course = courseBox.Text;
                editStudent.Gender = genderBox.Text;
                editStudent.Year = yearBox.Text;
				editStudent.StudentImage = ImagePath;

				Home.SaveToText();

				this.Close();
			}
		}

		private void ClearFields()
		{
			firstnameBox.Clear();
			lastnameBox.Clear();
			miBox.Clear();
			addressBox.Clear();
			courseBox.Text = "";
			yearBox.Clear();
			genderBox.Text = "";
			genderBox.Text = "";
		}
		private string Capitalize(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return text;

			text = text.Trim().ToLower();
			return char.ToUpper(text[0]) + text.Substring(1);
		}
		private void backButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void firstnameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void lastnameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void miBox_TextChanged(object sender, EventArgs e)
		{
			if (miBox.Text.Length > 1)
			{
				return;
			}
		}

		private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void birthdateBox_ValueChanged(object sender, EventArgs e)
		{

		}

		private void addressBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void yearBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
