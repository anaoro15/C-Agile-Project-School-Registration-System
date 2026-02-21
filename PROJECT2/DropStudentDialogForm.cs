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
    public partial class DropStudentDialogForm : Form
    {
        public Course SelectedCourse
        {
            get; set;
        }
        public DropStudentDialogForm()
        {
            InitializeComponent();
        }
        public void SetCourseDetails(Course course)
        {
            // populate listbox with student ids for the selected course
            foreach (var studentID in course.StudentIDs)
            {
                registeredStudentsListBox.Items.Add(studentID);
            }

        }
        private void dropStudentButton_Click(object sender, EventArgs e)
        {
            if (registeredStudentsListBox.SelectedIndex != -1)
            {
                string selectedStudentID = registeredStudentsListBox.SelectedItem.ToString();
                DialogResult confirmResult = MessageBox.Show($"Are you sure you want to drop student with ID: {selectedStudentID}?",

                    "Confirmation",


                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    SelectedCourse.StudentIDs.Remove(selectedStudentID);
                    registeredStudentsListBox.Text = string.Join(Environment.NewLine, SelectedCourse.StudentIDs);
                    MessageBox.Show($"Student with ID '{selectedStudentID}' dropped from the course.");

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to drop.");
            }
        }
    }
}

