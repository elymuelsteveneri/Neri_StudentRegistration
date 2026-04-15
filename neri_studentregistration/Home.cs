using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neri_studentregistration
{
    public partial class Home : Form
    {
        public static List<Student> studentList = new List<Student>();

        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentRegistration regForm = new StudentRegistration(null!);
            regForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            studentlist regForm = new studentlist();
            regForm.Show();
        }

        private static string jsonPath = "C:\\Users\\Student\\Downloads\\neri_studentregistrationzz\\neri_studentregistration\\neri_studentregistration\\neri_studentregistration\\StudentList.txt";

        public static void SaveToText()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(studentList, options);

            File.WriteAllText(jsonPath, jsonString);
        }
        public static void LoadToText()
        {
            if (!File.Exists(jsonPath)) return;

            string existingJson = File.ReadAllText(jsonPath);
            if (string.IsNullOrEmpty(existingJson)) return;

            studentList = JsonSerializer.Deserialize<List<Student>>(existingJson)!;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadToText();
        }
    }
}
