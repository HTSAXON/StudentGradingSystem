namespace StudentGradingSystem.GUI
{
    partial class FacultyCoursesForm
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
            gridCourses = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridCourses).BeginInit();
            SuspendLayout();
            // 
            // gridCourses
            // 
            gridCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCourses.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Status });
            gridCourses.Location = new Point(12, 12);
            gridCourses.Name = "gridCourses";
            gridCourses.RowHeadersWidth = 51;
            gridCourses.Size = new Size(892, 369);
            gridCourses.TabIndex = 0;
            // 
            // CourseID
            // 
            CourseID.DataPropertyName = "CourseId";
            CourseID.FillWeight = 160F;
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.Width = 125;
            // 
            // CourseName
            // 
            CourseName.DataPropertyName = "Course";
            CourseName.FillWeight = 160F;
            CourseName.HeaderText = "Course";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.FillWeight = 160F;
            Status.HeaderText = "Status";
            Status.Items.AddRange(new object[] { "Approved", "Rejected", "Pending" });
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // FacultyCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 401);
            Controls.Add(gridCourses);
            Name = "FacultyCoursesForm";
            Text = "Faculty Courses";
            ((System.ComponentModel.ISupportInitialize)gridCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCourses;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewComboBoxColumn Status;
    }
}