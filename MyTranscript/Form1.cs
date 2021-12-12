using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranscript
{
    public partial class Form1 : Form
    {
        List<Course> year1Sem1;
        List<Course> year1Sem2;
        List<Course> year2Sem1;
        List<Course> year2Sem2;
        List<Course> year2SemS;
        List<Course> year3Sem1;
        List<Course> year3Sem2;
        List<Course> year4Sem1;
        List<Course> year4Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();
            year2Sem1 = new List<Course>();
            year2Sem2 = new List<Course>();
            year2SemS = new List<Course>();
            year3Sem1 = new List<Course>();
            year3Sem2 = new List<Course>();
            year4Sem1 = new List<Course>();
            year4Sem2 = new List<Course>();
        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBoxCourseID.Text;
            newCourse.CourseName = textBoxCourseName.Text;
            newCourse.CourseCredit = textBoxCourseCredit.Text;
            newCourse.Grade = textBoxGrade.Text;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridViewY1S1.DataSource = null;
                    year1Sem1.Add(newCourse);
                    dataGridViewY1S1.DataSource = year1Sem1;
                    break;
                case 1:
                    dataGridViewY1S2.DataSource = null;
                    year1Sem2.Add(newCourse);
                    dataGridViewY1S2.DataSource = year1Sem2;
                    break;
                case 2:
                    dataGridViewY2S1.DataSource = null;
                    year2Sem1.Add(newCourse);
                    dataGridViewY2S1.DataSource = year2Sem1;
                    break;
                case 3:
                    dataGridViewY2S2.DataSource = null;
                    year2Sem2.Add(newCourse);
                    dataGridViewY2S2.DataSource = year2Sem2;
                    break;
                case 4:
                    dataGridViewY2SS.DataSource = null;
                    year2SemS.Add(newCourse);
                    dataGridViewY2SS.DataSource = year2SemS;
                    break;
                case 5:
                    dataGridViewY3S1.DataSource = null;
                    year3Sem1.Add(newCourse);
                    dataGridViewY3S1.DataSource = year3Sem1;
                    break;
                case 6:
                    dataGridViewY3S2.DataSource = null;
                    year3Sem2.Add(newCourse);
                    dataGridViewY3S2.DataSource = year3Sem2;
                    break;
                case 7:
                    dataGridViewY4S1.DataSource = null;
                    year4Sem1.Add(newCourse);
                    dataGridViewY4S1.DataSource = year4Sem1;
                    break;
                case 8:
                    dataGridViewY4S2.DataSource = null;
                    year4Sem2.Add(newCourse);
                    dataGridViewY4S2.DataSource = year4Sem2;
                    break;
            }
        }

        class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public string CourseCredit { get; set; }
            public string Grade { get; set; }

            public override string ToString()
            {
                return CourseID + "," + CourseName + "," + CourseCredit + "," + Grade;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int counter;

            sb.AppendLine(labelUniversityName.Text);
            sb.AppendLine(labelFacultyName.Text);

            // Year 1 Semester 1
            if (year1Sem1.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 1 Semester 2
            if (year1Sem2.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 2 Semester 1
            if (year2Sem1.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 2 Semester 2
            if (year2Sem2.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 2 Summer
            if (year2SemS.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 2 Summer");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year2SemS)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 3 Semester 1
            if (year3Sem1.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 3 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year3Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 3 Semester 2
            if (year3Sem2.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 3 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year3Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 4 Semester 1
            if (year4Sem1.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 4 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year4Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 4 Semester 2
            if (year4Sem2.Count > 0)
            {
                sb.AppendLine("");
                sb.AppendLine("Year 4 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year4Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save CSV Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteToFile(saveFileDialog1.FileName, sb);
            }
        }

        private void WriteToFile(string filename, StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
            System.IO.File.WriteAllText(filename, sb.ToString());
        }
    }
}
