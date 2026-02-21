namespace PROJECT2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addCourseButton = new Button();
            modifyCourseButton = new Button();
            deleteCourseButton = new Button();
            displayCoursesButton = new Button();
            closeButton = new Button();
            addDropStudentsButton = new Button();
            SuspendLayout();
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(136, 73);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(139, 48);
            addCourseButton.TabIndex = 0;
            addCourseButton.Text = "ADD COURSE";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            addCourseButton.MouseEnter += addCourseButton_MouseEnter;
            addCourseButton.MouseLeave += addCourseButton_MouseLeave;
            // 
            // modifyCourseButton
            // 
            modifyCourseButton.Location = new Point(377, 73);
            modifyCourseButton.Name = "modifyCourseButton";
            modifyCourseButton.Size = new Size(139, 48);
            modifyCourseButton.TabIndex = 1;
            modifyCourseButton.Text = "MODIFY COURSE";
            modifyCourseButton.UseVisualStyleBackColor = true;
            modifyCourseButton.Click += modifyCourseButton_Click;
            modifyCourseButton.MouseEnter += modifyCourseButton_MouseEnter;
            modifyCourseButton.MouseLeave += modifyCourseButton_MouseLeave;
            // 
            // deleteCourseButton
            // 
            deleteCourseButton.Location = new Point(136, 196);
            deleteCourseButton.Name = "deleteCourseButton";
            deleteCourseButton.Size = new Size(139, 48);
            deleteCourseButton.TabIndex = 2;
            deleteCourseButton.Text = "DELETE COURSE";
            deleteCourseButton.UseVisualStyleBackColor = true;
            deleteCourseButton.Click += deleteCourseButton_Click;
            deleteCourseButton.MouseEnter += deleteCourseButton_MouseEnter;
            deleteCourseButton.MouseLeave += deleteCourseButton_MouseLeave;
            // 
            // displayCoursesButton
            // 
            displayCoursesButton.Location = new Point(377, 196);
            displayCoursesButton.Name = "displayCoursesButton";
            displayCoursesButton.Size = new Size(139, 48);
            displayCoursesButton.TabIndex = 3;
            displayCoursesButton.Text = "DISPLAY COURSES";
            displayCoursesButton.UseVisualStyleBackColor = true;
            displayCoursesButton.Click += displayCoursesButton_Click;
            displayCoursesButton.MouseEnter += displayCoursesButton_MouseEnter;
            displayCoursesButton.MouseLeave += displayCoursesButton_MouseLeave;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(348, 302);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(133, 36);
            closeButton.TabIndex = 5;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // addDropStudentsButton
            // 
            addDropStudentsButton.Location = new Point(154, 302);
            addDropStudentsButton.Name = "addDropStudentsButton";
            addDropStudentsButton.Size = new Size(150, 36);
            addDropStudentsButton.TabIndex = 6;
            addDropStudentsButton.Text = "ADD/DROP STUDENT";
            addDropStudentsButton.UseVisualStyleBackColor = true;
            addDropStudentsButton.Click += addDropStudentsButton_Click;
            addDropStudentsButton.MouseEnter += addDropStudentsButton_MouseEnter;
            addDropStudentsButton.MouseLeave += addDropStudentsButton_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.school_board_png;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(652, 450);
            Controls.Add(addDropStudentsButton);
            Controls.Add(closeButton);
            Controls.Add(displayCoursesButton);
            Controls.Add(deleteCourseButton);
            Controls.Add(modifyCourseButton);
            Controls.Add(addCourseButton);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "COURSE INFORMATION";
            TransparencyKey = Color.FromArgb(0, 192, 192);
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addCourseButton;
        private Button modifyCourseButton;
        private Button deleteCourseButton;
        private Button displayCoursesButton;
        private Button closeButton;
        private Button addDropStudentsButton;
    }
}