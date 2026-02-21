namespace PROJECT2
{
    partial class ModifyCourseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            descriptionTextBox = new TextBox();
            courseTitleTextBox = new TextBox();
            seatingCapacityTextBox = new TextBox();
            closeButton = new Button();
            modifyButton = new Button();
            SuspendLayout();
            // 
            // courseNumberComboBox
            // 
            courseNumberComboBox.FormattingEnabled = true;
            courseNumberComboBox.Location = new Point(54, 34);
            courseNumberComboBox.Name = "courseNumberComboBox";
            courseNumberComboBox.Size = new Size(655, 23);
            courseNumberComboBox.TabIndex = 0;
            courseNumberComboBox.SelectedIndexChanged += courseNumberComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 1;
            label1.Text = "Existing Course Numbers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Course Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 149);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Course Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 222);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Seating Capacity:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(54, 182);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(655, 23);
            descriptionTextBox.TabIndex = 5;
            // 
            // courseTitleTextBox
            // 
            courseTitleTextBox.Location = new Point(54, 104);
            courseTitleTextBox.Name = "courseTitleTextBox";
            courseTitleTextBox.Size = new Size(655, 23);
            courseTitleTextBox.TabIndex = 6;
            // 
            // seatingCapacityTextBox
            // 
            seatingCapacityTextBox.Location = new Point(54, 261);
            seatingCapacityTextBox.Name = "seatingCapacityTextBox";
            seatingCapacityTextBox.Size = new Size(655, 23);
            seatingCapacityTextBox.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(509, 352);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(200, 43);
            closeButton.TabIndex = 10;
            closeButton.Text = "CL&OSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(60, 352);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(200, 43);
            modifyButton.TabIndex = 11;
            modifyButton.Text = "MOD&IFY";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // ModifyCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modifyButton);
            Controls.Add(closeButton);
            Controls.Add(seatingCapacityTextBox);
            Controls.Add(courseTitleTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(courseNumberComboBox);
            Name = "ModifyCourseForm";
            Text = "ModifyCourseForm";
            Load += ModifyCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseNumberComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox descriptionTextBox;
        private TextBox courseTitleTextBox;
        private TextBox seatingCapacityTextBox;
        private Button closeButton;
        private Button modifyButton;
    }
}