using System.Net.Http.Headers;

namespace PROJECT2
{
    public partial class MainForm : Form
    {
        private List<Course> courses = new List<Course>();
        private string filePath = "courses.txt"; // text file to store the data
        public MainForm()
        {
            InitializeComponent();
            LoadCoursesFromFile();
        }
        private void LoadCoursesFromFile()
        {
            // Load existing courses from the text file when the app starts
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (data.Length == 4)
                    {
                        int courseNumber = int.Parse(data[0]);
                        string courseTitle = data[1];
                        string courseDescription = data[2];
                        int seatingCapacity = int.Parse(data[3]);
                        Course course = new Course(courseNumber, courseTitle, courseDescription, seatingCapacity);
                        courses.Add(course);

                        // display course in UI or list
                        // example listBocCourses.Items.Add(course);
                    }
                }
            }
        }
        private void SaveCoursesToFile()
        {
            // save courses to the text file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Course course in courses)
                {
                    writer.WriteLine($"{course.CourseNumber};{course.CourseTitle};{course.CourseDescription};{course.SeatingCapacity}");
                }
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm(courses);
            addCourseForm.ShowDialog();
        }

        private void modifyCourseButton_Click(object sender, EventArgs e)
        {
            ModifyCourseForm modifyCourseForm = new ModifyCourseForm(courses);
            modifyCourseForm.ShowDialog();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm(courses);
            deleteCourseForm.ShowDialog();
        }

        private void displayCoursesButton_Click(object sender, EventArgs e)
        {
            DisplayCoursesForm displayCoursesForm = new DisplayCoursesForm(courses);
            displayCoursesForm.ShowDialog();
        }

        private void addCourseButton_MouseEnter(object sender, EventArgs e)
        {
            addCourseButton.BackColor = Color.LightCoral;  // change background color on mouse enter
            addCourseButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void addCourseButton_MouseLeave(object sender, EventArgs e)
        {
            addCourseButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            addCourseButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
        }

        private void modifyCourseButton_MouseEnter(object sender, EventArgs e)
        {
            modifyCourseButton.BackColor = Color.LightCoral;  // change background color on mouse enter
            modifyCourseButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void modifyCourseButton_MouseLeave(object sender, EventArgs e)
        {
            modifyCourseButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            modifyCourseButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
        }

        private void deleteCourseButton_MouseEnter(object sender, EventArgs e)
        {
            deleteCourseButton.BackColor = Color.LightCoral;  // change background color on mouse enter
            deleteCourseButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void deleteCourseButton_MouseLeave(object sender, EventArgs e)
        {
            deleteCourseButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            deleteCourseButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
        }

        private void displayCoursesButton_MouseEnter(object sender, EventArgs e)
        {
            displayCoursesButton.BackColor = Color.LightCoral;  // change background color on mouse enter
            displayCoursesButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void displayCoursesButton_MouseLeave(object sender, EventArgs e)
        {
            displayCoursesButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            displayCoursesButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
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

        private void addDropStudentsButton_Click(object sender, EventArgs e)
        {
            AddDropStudentForm addDropStudentForm = new AddDropStudentForm(courses);
            addDropStudentForm.ShowDialog();
        }

        private void addDropStudentsButton_MouseEnter(object sender, EventArgs e)
        {
            addDropStudentsButton.BackColor = Color.Black;  // change background color on mouse enter
            addDropStudentsButton.ForeColor = Color.White;  // change text color on mouse enter
        }

        private void addDropStudentsButton_MouseLeave(object sender, EventArgs e)
        {
            addDropStudentsButton.BackColor = SystemColors.Control;  // change background color on mouse leave
            addDropStudentsButton.ForeColor = SystemColors.ControlText;  // change text color on mouse leave
        }
    }
}