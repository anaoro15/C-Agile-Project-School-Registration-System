using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT2
{
    public partial class AddCourseForm : Form
    {
        private List<Course> courses;

        public AddCourseForm(List<Course> existingCourses)
        {
            InitializeComponent();
            courses = existingCourses;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // event handler for the "add" button click
        private void addButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("courses.txt");
            try
            {
                // Retreive input values from textboxes
                int courseNumber = int.Parse(courseNumberTextBox.Text);  // assuming course number is an integer
                string courseTitle = courseTitleTextBox.Text;
                string courseDescription = descriptionTextBox.Text;
                int seatingCapacity = int.Parse(seatingCapacityTextBox.Text);

                // create a new Course object
                Course newCourse = new Course(courseNumber, courseTitle, courseDescription, seatingCapacity);

                // check if the course with the same number already exists
                bool courseExists = courses.Any(course => course.CourseNumber == courseNumber);
                if (courseExists)
                {
                    MessageBox.Show("Course with the same number already exists. Please use a different number.");
                }
                else
                {
                    courses.Add(newCourse);
                    sw.WriteLine(newCourse);
                    MessageBox.Show("Course added successfully.");

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter a numeric values for course number and seating capacity.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void clearButtom_Click(object sender, EventArgs e)
        {
            courseNumberTextBox.Clear();
            courseTitleTextBox.Clear();
            descriptionTextBox.Clear();
            seatingCapacityTextBox.Clear();
            courseNumberTextBox.Focus();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
