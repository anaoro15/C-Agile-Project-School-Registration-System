namespace PROJECT2
{
    partial class AddStudentDialogForm
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
            studentIdTextBox = new TextBox();
            label1 = new Label();
            addButton = new Button();
            SuspendLayout();
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Location = new Point(82, 68);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(164, 23);
            studentIdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 50);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID:";
            // 
            // addButton
            // 
            addButton.Location = new Point(113, 97);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 34);
            addButton.TabIndex = 2;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddStudentDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 153);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(studentIdTextBox);
            Name = "AddStudentDialogForm";
            Text = "AddStudentDialogForm";
            Load += AddStudentDialogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentIdTextBox;
        private Label label1;
        private Button addButton;
    }
}