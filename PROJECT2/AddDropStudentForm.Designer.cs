namespace PROJECT2
{
    partial class AddDropStudentForm
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
            comboBoxCourses = new ComboBox();
            addStudentButton = new Button();
            addSeatsButton = new Button();
            dropStudentButton = new Button();
            closeButton = new Button();
            seatingCapacityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            registeredStudentsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(149, 45);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(121, 23);
            comboBoxCourses.TabIndex = 0;
            comboBoxCourses.SelectedIndexChanged += comboBoxCourses_SelectedIndexChanged;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(96, 204);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(147, 69);
            addStudentButton.TabIndex = 1;
            addStudentButton.Text = "ADD STUDENT";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // addSeatsButton
            // 
            addSeatsButton.Location = new Point(509, 204);
            addSeatsButton.Name = "addSeatsButton";
            addSeatsButton.Size = new Size(147, 69);
            addSeatsButton.TabIndex = 2;
            addSeatsButton.Text = "ADD SEATS";
            addSeatsButton.UseVisualStyleBackColor = true;
            // 
            // dropStudentButton
            // 
            dropStudentButton.Location = new Point(306, 204);
            dropStudentButton.Name = "dropStudentButton";
            dropStudentButton.Size = new Size(147, 69);
            dropStudentButton.TabIndex = 3;
            dropStudentButton.Text = "DROP STUDENT";
            dropStudentButton.UseVisualStyleBackColor = true;
            dropStudentButton.Click += dropStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(306, 339);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(147, 69);
            closeButton.TabIndex = 5;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            // 
            // seatingCapacityTextBox
            // 
            seatingCapacityTextBox.Location = new Point(149, 120);
            seatingCapacityTextBox.Name = "seatingCapacityTextBox";
            seatingCapacityTextBox.Size = new Size(100, 23);
            seatingCapacityTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 102);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 8;
            label2.Text = "Seating Capacity:";
            // 
            // registeredStudentsTextBox
            // 
            registeredStudentsTextBox.Location = new Point(453, 120);
            registeredStudentsTextBox.Name = "registeredStudentsTextBox";
            registeredStudentsTextBox.Size = new Size(100, 23);
            registeredStudentsTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 27);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 10;
            label3.Text = "Course Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 102);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 11;
            label4.Text = "Number of Registered Students:";
            // 
            // AddDropStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(registeredStudentsTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(seatingCapacityTextBox);
            Controls.Add(closeButton);
            Controls.Add(dropStudentButton);
            Controls.Add(addSeatsButton);
            Controls.Add(addStudentButton);
            Controls.Add(comboBoxCourses);
            Name = "AddDropStudentForm";
            Text = "AddDropStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCourses;
        private Button addStudentButton;
        private Button addSeatsButton;
        private Button dropStudentButton;
        private Button closeButton;
        private TextBox seatingCapacityTextBox;
        private Label label1;
        private Label label2;
        private TextBox registeredStudentsTextBox;
        private Label label3;
        private Label label4;
    }
}