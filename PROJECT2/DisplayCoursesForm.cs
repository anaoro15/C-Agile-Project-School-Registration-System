using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT2
{
    public partial class DisplayCoursesForm : Form
    {
        private List<Course> courses;
        public DisplayCoursesForm(List<Course> allCourses)
        {
            InitializeComponent();
            courses = allCourses;

            DisplayAllCourses();
        }
        private void DisplayAllCourses()
        {
            foreach (Course course in courses)
            {
                ListViewItem item = new ListViewItem(course.CourseNumber.ToString());
                item.SubItems.Add(course.CourseTitle);
                item.SubItems.Add(course.CourseDescription);
                item.SubItems.Add(course.SeatingCapacity.ToString());

                // add the count of registered students
                item.SubItems.Add(course.StudentIDs.Count.ToString());
                listViewCourses.Items.Add(item);
            }
        }

        private void listViewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCourses.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCourses.SelectedItems[0];

                // access course details from the selected item's sub-items
                string courseNumber = selectedItem.SubItems[0].Text;
                string courseTitle = selectedItem.SubItems[1].Text;
                string courseDescription = selectedItem.SubItems[2].Text;
                string seatingCapacity = selectedItem.SubItems[3].Text;
                string registeredStudents = selectedItem.SubItems[4].Text;
            }
        }
        private PrintDocument printDocument = new PrintDocument();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // define font and brush for printing 
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // define printing area and line heigth
            int x = 50, y = 50;
            int lineHeigth = 20;

            foreach (ListViewItem item in listViewCourses.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    e.Graphics.DrawString(subItem.Text, font, brush, x, y);
                    y += lineHeigth;
                }
                y += lineHeigth; // add space between items
            }
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayCoursesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
