namespace PROJECT2
{
    partial class DisplayCoursesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewCourses = new ListView();
            courseNumberCoolumn = new ColumnHeader();
            courseTitleColumn = new ColumnHeader();
            courseDescriptionColumn = new ColumnHeader();
            seatingCapacityColumn = new ColumnHeader();
            studentsIDsColumn = new ColumnHeader();
            label1 = new Label();
            closeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // listViewCourses
            // 
            listViewCourses.Columns.AddRange(new ColumnHeader[] { courseNumberCoolumn, courseTitleColumn, courseDescriptionColumn, seatingCapacityColumn, studentsIDsColumn });
            listViewCourses.Location = new Point(29, 56);
            listViewCourses.Name = "listViewCourses";
            listViewCourses.Size = new Size(734, 313);
            listViewCourses.TabIndex = 0;
            listViewCourses.UseCompatibleStateImageBehavior = false;
            listViewCourses.View = View.Details;
            listViewCourses.SelectedIndexChanged += listViewCourses_SelectedIndexChanged;
            // 
            // courseNumberCoolumn
            // 
            courseNumberCoolumn.Text = "Course Number:";
            courseNumberCoolumn.Width = 120;
            // 
            // courseTitleColumn
            // 
            courseTitleColumn.Text = "Course Title:";
            courseTitleColumn.TextAlign = HorizontalAlignment.Center;
            courseTitleColumn.Width = 140;
            // 
            // courseDescriptionColumn
            // 
            courseDescriptionColumn.Text = "Course Description:";
            courseDescriptionColumn.TextAlign = HorizontalAlignment.Center;
            courseDescriptionColumn.Width = 190;
            // 
            // seatingCapacityColumn
            // 
            seatingCapacityColumn.Text = "Seating Capacity:";
            seatingCapacityColumn.TextAlign = HorizontalAlignment.Center;
            seatingCapacityColumn.Width = 140;
            // 
            // studentsIDsColumn
            // 
            studentsIDsColumn.Text = "Students Registered:";
            studentsIDsColumn.TextAlign = HorizontalAlignment.Center;
            studentsIDsColumn.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Course Details:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(547, 393);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(158, 45);
            closeButton.TabIndex = 2;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(71, 393);
            printButton.Name = "printButton";
            printButton.Size = new Size(158, 45);
            printButton.TabIndex = 3;
            printButton.Text = "PR&INT";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click_1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // DisplayCoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(listViewCourses);
            Name = "DisplayCoursesForm";
            Text = "DisplayCoursesForm";
            Load += DisplayCoursesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCourses;
        private Label label1;
        private ColumnHeader courseNumberCoolumn;
        private ColumnHeader courseTitleColumn;
        private ColumnHeader courseDescriptionColumn;
        private ColumnHeader seatingCapacityColumn;
        private ColumnHeader studentsIDsColumn;
        private Button closeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}