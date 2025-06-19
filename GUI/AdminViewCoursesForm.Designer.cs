namespace StudentGradingSystem.GUI
{
    partial class AdminViewCoursesForm
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
            dataGridView1 = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            View = new DataGridViewButtonColumn();
            Submit = new DataGridViewButtonColumn();
            lable_courses = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Status, View, Submit });
            dataGridView1.Location = new Point(0, 116);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(762, 311);
            dataGridView1.TabIndex = 0;
            // 
            // CourseID
            // 
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.Width = 120;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // View
            // 
            View.HeaderText = "View Students";
            View.MinimumWidth = 6;
            View.Name = "View";
            View.Width = 125;
            // 
            // Submit
            // 
            Submit.HeaderText = "Submit";
            Submit.MinimumWidth = 6;
            Submit.Name = "Submit";
            Submit.Width = 125;
            // 
            // lable_courses
            // 
            lable_courses.AutoSize = true;
            lable_courses.BackColor = SystemColors.ButtonFace;
            lable_courses.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable_courses.ForeColor = SystemColors.ActiveCaptionText;
            lable_courses.Location = new Point(209, 27);
            lable_courses.Margin = new Padding(4, 0, 4, 0);
            lable_courses.Name = "lable_courses";
            lable_courses.Size = new Size(337, 42);
            lable_courses.TabIndex = 1;
            lable_courses.Text = "Avaliable Courses";
            lable_courses.Click += lable_courses_Click;
            // 
            // AdminViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(767, 442);
            Controls.Add(lable_courses);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdminViewCoursesForm";
            Text = "AdminViewCoursesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Submit;
        private System.Windows.Forms.Label lable_courses;
    }
}