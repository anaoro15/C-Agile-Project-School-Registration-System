namespace PROJECT2
{
    partial class DeleteCourseForm
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
            courseNumberComboBox = new ComboBox();
            courseTitleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            seatingCapacityTextBox = new TextBox();
            closeButton = new Button();
            deleteButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // courseNumberComboBox
            // 
            courseNumberComboBox.FormattingEnabled = true;
            courseNumberComboBox.Location = new Point(75, 57);
            courseNumberComboBox.Name = "courseNumberComboBox";
            courseNumberComboBox.Size = new Size(250, 23);
            courseNumberComboBox.TabIndex = 0;
            courseNumberComboBox.SelectedIndexChanged += courseNumberComboBox_SelectedIndexChanged;
            // 
            // courseTitleTextBox
            // 
            courseTitleTextBox.Location = new Point(75, 130);
            courseTitleTextBox.Name = "courseTitleTextBox";
            courseTitleTextBox.Size = new Size(604, 23);
            courseTitleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(75, 212);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(604, 23);
            descriptionTextBox.TabIndex = 3;
            // 
            // seatingCapacityTextBox
            // 
            seatingCapacityTextBox.Location = new Point(75, 294);
            seatingCapacityTextBox.Name = "seatingCapacityTextBox";
            seatingCapacityTextBox.Size = new Size(604, 23);
            seatingCapacityTextBox.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(459, 371);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(240, 41);
            closeButton.TabIndex = 5;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(75, 371);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(240, 41);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "DE&LETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 7;
            label1.Text = "Existing Course Numbers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 98);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Course Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 176);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 9;
            label3.Text = "Course Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 257);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 10;
            label4.Text = "Seating Capacity:";
            // 
            // DeleteCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(closeButton);
            Controls.Add(seatingCapacityTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(courseTitleTextBox);
            Controls.Add(courseNumberComboBox);
            Name = "DeleteCourseForm";
            Text = "DeleteCourseForm";
            Load += DeleteCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseNumberComboBox;
        private TextBox courseTitleTextBox;
        private TextBox descriptionTextBox;
        private TextBox seatingCapacityTextBox;
        private Button closeButton;
        private Button deleteButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}