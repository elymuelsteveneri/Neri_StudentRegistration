using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static neri_studentregistration.Program;

namespace neri_studentregistration
{
	public partial class studentlist : Form
	{
		public studentlist()
		{
			InitializeComponent();
			LoadStudents();
		}
		private void LoadStudents()
		{
			viewstudents.Rows.Clear();

			foreach (var student in StudentRepository.Students)
			{
				viewstudents.Rows.Add(
					student.FirstName,
					student.LastName,
					student.Course
				);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void viewstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


			foreach (var student in StudentRepository.Students)
			{
				viewstudents.Rows.Add(
					student.FirstName,
					student.LastName,
					student.Course
				);
			}
		}

			private void viewstudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var selectedStudent = (Student)viewstudents.Rows[e.RowIndex].DataBoundItem;

				studentinformation infoForm = new studentinformation(selectedStudent);
				infoForm.ShowDialog();
				

			}

        }
        
    
        private void studentlist_Load(object sender, EventArgs e)
		{
			viewstudents.DataSource = Home.studentList;

			foreach (DataGridViewColumn col in viewstudents.Columns)
			{
				col.Visible = false;
			}

			viewstudents.Columns["FirstName"].Visible = true;
			viewstudents.Columns["LastName"].Visible = true;
			viewstudents.Columns["Course"].Visible = true;
			viewstudents.Columns["Year"].Visible = true;
		}
	}
}
