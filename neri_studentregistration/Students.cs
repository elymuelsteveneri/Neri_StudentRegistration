using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neri_studentregistration
{
	public class Student
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? MiddleInitial { get; set; }
		public DateTime Birthdate { get; set; }
		public string? Gender { get; set; }
		public string? Address { get; set; }
		public string? Course { get; set; }
		public string? Year { get; set; }
		public string? StudentImage { get; set; }
	}
}
