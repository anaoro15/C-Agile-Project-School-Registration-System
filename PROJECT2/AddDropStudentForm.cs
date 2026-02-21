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
    public partial class AddDropStudentForm : Form
    {
        private Course selectedCourse; // this is assumed to be selected course for adding or dropping students
        private List<Course> courses;
        public AddDropStudentForm(List<Course> allCourses)
        {
            InitializeComponent();
            courses = allCourses;

            foreach (Course course in courses)
            {
                comboBoxCourses.Items.Add(course.CourseNumber);
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Black;  // change background color on mouse enter
            closeButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            closeButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
        }

        public void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCourseNumber = (int)comboBoxCourses.SelectedItem;

            // find the selected course based on the courseNumber
            selectedCourse = courses.FirstOrDefault(course => course.CourseNumber == selectedCourseNumber);

            if (selectedCourse != null)
            {
                seatingCapacityTextBox.Text = selectedCourse.SeatingCapacity.ToString();
                registeredStudentsTextBox.Text = selectedCourse.StudentIDs.Count.ToString();

                if (selectedCourse.StudentIDs.Count >= selectedCourse.SeatingCapacity)
                {
                    MessageBox.Show("The class is full. No additional students can be added.");
                }
                else if (selectedCourse.StudentIDs.Count == 0)
                {
                    DialogResult result = MessageBox.Show("The class is empty. Do you want to delete this course?",
                        "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        courses.Remove(selectedCourse);  // remove the selected course from the list
                        comboBoxCourses.Items.Remove(selectedCourse.CourseNumber); // remove it from the combo box
                    }

                }
            }
            else
            {
                MessageBox.Show("Selected course not found.");
            }

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                using (var addStudentDialog = new AddStudentDialogForm())
                {
                    addStudentDialog.SelectedCourse = selectedCourse; // pass the selected course to the dialog form
                    addStudentDialog.RegisteredStudentsTextBox = registeredStudentsTextBox;
                    var result = addStudentDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course.");
            }
        }

        private void dropStudentButton_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                using (var dropStudentDialog = new DropStudentDialogForm())
                {
                    dropStudentDialog.SelectedCourse = selectedCourse; // pass the selected course to the dialog form
                    dropStudentDialog.SetCourseDetails(selectedCourse);

                    var result = dropStudentDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course.");
            }
        }
    }
}
