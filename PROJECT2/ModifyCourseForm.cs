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
    public partial class ModifyCourseForm : Form
    {
        private Course selectedCourse;
        private List<Course> courses;
        public ModifyCourseForm(List<Course> allCourses)
        {
            InitializeComponent();
            courses = allCourses;
            foreach (Course course in courses)
            {
                courseNumberComboBox.Items.Add(course.CourseNumber);
            }
        }
        private void courseNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCourseNumber;
            if (int.TryParse(courseNumberComboBox.SelectedItem.ToString(), out selectedCourseNumber))
            {
                selectedCourse = courses.FirstOrDefault(c => c.CourseNumber == selectedCourseNumber);
                if (selectedCourse != null)
                {
                    // display course details for modification
                    courseTitleTextBox.Text = selectedCourse.CourseTitle;
                    descriptionTextBox.Text = selectedCourse.CourseDescription;
                    seatingCapacityTextBox.Text = selectedCourse.SeatingCapacity.ToString();
                }
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCourse != null)
                {
                    // update the selected course with modified details
                    selectedCourse.CourseTitle = courseTitleTextBox.Text;
                    selectedCourse.CourseDescription = descriptionTextBox.Text;
                    selectedCourse.SeatingCapacity = int.Parse(seatingCapacityTextBox.Text);
                    MessageBox.Show("Course modified successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a course.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter a numeric value for seating capacity.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurredL {ex.Message}");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
