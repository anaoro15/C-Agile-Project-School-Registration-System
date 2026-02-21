namespace PROJECT2
{
    partial class DropStudentDialogForm
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
            dropStudentButton = new Button();
            groupBox1 = new GroupBox();
            registeredStudentsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 1;
            label1.Text = "Registered Students ID list:";
            // 
            // dropStudentButton
            // 
            dropStudentButton.Location = new Point(139, 201);
            dropStudentButton.Name = "dropStudentButton";
            dropStudentButton.Size = new Size(119, 38);
            dropStudentButton.TabIndex = 2;
            dropStudentButton.Text = "DR&OP";
            dropStudentButton.UseVisualStyleBackColor = true;
            dropStudentButton.Click += dropStudentButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(registeredStudentsListBox);
            groupBox1.Controls.Add(dropStudentButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // registeredStudentsListBox
            // 
            registeredStudentsListBox.FormattingEnabled = true;
            registeredStudentsListBox.ItemHeight = 15;
            registeredStudentsListBox.Location = new Point(35, 55);
            registeredStudentsListBox.Name = "registeredStudentsListBox";
            registeredStudentsListBox.Size = new Size(319, 124);
            registeredStudentsListBox.TabIndex = 3;
            // 
            // DropStudentDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 251);
            Controls.Add(groupBox1);
            Name = "DropStudentDialogForm";
            Text = "DropStudentDialogForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button dropStudentButton;
        private GroupBox groupBox1;
        private ListBox registeredStudentsListBox;
    }
}