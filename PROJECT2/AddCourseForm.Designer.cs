namespace PROJECT2
{
    partial class AddCourseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            closeButton = new Button();
            clearButtom = new Button();
            addButton = new Button();
            courseNumberTextBox = new TextBox();
            courseTitleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            seatingCapacityTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 179);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Course Description: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 265);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Seating Capacity:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(582, 360);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(129, 48);
            closeButton.TabIndex = 8;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButtom
            // 
            clearButtom.Location = new Point(324, 360);
            clearButtom.Name = "clearButtom";
            clearButtom.Size = new Size(129, 48);
            clearButtom.TabIndex = 9;
            clearButtom.Text = "CL&EAR";
            clearButtom.UseVisualStyleBackColor = true;
            clearButtom.Click += clearButtom_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(82, 360);
            addButton.Name = "addButton";
            addButton.Size = new Size(129, 48);
            addButton.TabIndex = 10;
            addButton.Text = "A&DD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // courseNumberTextBox
            // 
            courseNumberTextBox.Location = new Point(82, 59);
            courseNumberTextBox.Name = "courseNumberTextBox";
            courseNumberTextBox.Size = new Size(101, 23);
            courseNumberTextBox.TabIndex = 11;
            // 
            // courseTitleTextBox
            // 
            courseTitleTextBox.Location = new Point(82, 129);
            courseTitleTextBox.Name = "courseTitleTextBox";
            courseTitleTextBox.Size = new Size(617, 23);
            courseTitleTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(82, 211);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(617, 23);
            descriptionTextBox.TabIndex = 13;
            // 
            // seatingCapacityTextBox
            // 
            seatingCapacityTextBox.Location = new Point(82, 297);
            seatingCapacityTextBox.Name = "seatingCapacityTextBox";
            seatingCapacityTextBox.Size = new Size(101, 23);
            seatingCapacityTextBox.TabIndex = 14;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seatingCapacityTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(courseTitleTextBox);
            Controls.Add(courseNumberTextBox);
            Controls.Add(addButton);
            Controls.Add(clearButtom);
            Controls.Add(closeButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            Load += AddCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button closeButton;
        private Button clearButtom;
        private Button addButton;
        private TextBox courseNumberTextBox;
        private TextBox courseTitleTextBox;
        private TextBox descriptionTextBox;
        private TextBox seatingCapacityTextBox;
    }
}