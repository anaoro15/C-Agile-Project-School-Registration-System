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
    public partial class AddStudentDialogForm : Form
    {
        public AddStudentDialogForm()
        {
            InitializeComponent();
        }
        public string StudentID
        {
            get { return studentIdTextBox.Text.Trim(); }
        }
        public Course SelectedCourse
        {
            get; set;
        }
        public TextBox RegisteredStudentsTextBox
        {
            get; set;
        }
        private void AddStudentDialogForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (SelectedCourse != null &&
                RegisteredStudentsTextBox != null)
            {
                string studentID = studentIdTextBox.Text.Trim();  // get the entered student id from the dialog
                if (!string.IsNullOrEmpty(studentID))
                {
                    if (SelectedCourse.StudentIDs.Count < SelectedCourse.SeatingCapacity)
                    {
                        if (!SelectedCourse.StudentIDs.Contains(studentID))
                        {
                            SelectedCourse.StudentIDs.Add(studentID);
                            RegisteredStudentsTextBox.Text = SelectedCourse.StudentIDs.Count.ToString();

                            MessageBox.Show($"Student with ID: {studentID} added to course successfuly.");
                            studentIdTextBox.Clear();
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show($"Student with ID '{studentID}' is already registered in this course.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The class is full. No additional students can be added.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a student ID.");
                }
            }
        }
    }
}
