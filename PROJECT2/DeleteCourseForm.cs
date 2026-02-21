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
    public partial class DeleteCourseForm : Form
    {
        private Course selectedCourse;
        private List<Course> courses;
        public DeleteCourseForm(List<Course> allCourses)
        {
            InitializeComponent();
            courses = allCourses;

            // Populate the ComboBox with existing course numbers
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
                    // display course details for deleting
                    courseTitleTextBox.Text = selectedCourse.CourseTitle;
                    descriptionTextBox.Text = selectedCourse.CourseDescription;
                    seatingCapacityTextBox.Text = selectedCourse.SeatingCapacity.ToString();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                if (selectedCourse.StudentIDs.Count == 0)
                {
                    courses.Remove(selectedCourse);
                    MessageBox.Show("Course deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Cannot delete a course with registered students.");
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }

            courseTitleTextBox.Clear();
            descriptionTextBox.Clear();
            seatingCapacityTextBox.Clear();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
