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
            dataGridView1 = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            Approve = new DataGridViewButtonColumn();
            Reject = new DataGridViewButtonColumn();
            ViewStudents = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Status, Approve, Reject, ViewStudents });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 369);
            dataGridView1.TabIndex = 0;
            // 
            // CourseID
            // 
            CourseID.FillWeight = 160F;
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.Width = 125;
            // 
            // CourseName
            // 
            CourseName.FillWeight = 160F;
            CourseName.HeaderText = "Course";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 125;
            // 
            // Status
            // 
            Status.FillWeight = 160F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Approve
            // 
            Approve.FillWeight = 160F;
            Approve.HeaderText = "Approve";
            Approve.MinimumWidth = 6;
            Approve.Name = "Approve";
            Approve.Width = 125;
            // 
            // Reject
            // 
            Reject.HeaderText = "Reject";
            Reject.MinimumWidth = 6;
            Reject.Name = "Reject";
            Reject.Width = 160;
            // 
            // ViewStudents
            // 
            ViewStudents.HeaderText = "View Students";
            ViewStudents.MinimumWidth = 6;
            ViewStudents.Name = "ViewStudents";
            ViewStudents.Width = 160;
            // 
            // FacultyCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 401);
            Controls.Add(dataGridView1);
            Name = "FacultyCoursesForm";
            Text = "Faculty Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewComboBoxColumn Status;
        private DataGridViewButtonColumn Approve;
        private DataGridViewButtonColumn Reject;
        private DataGridViewTextBoxColumn ViewStudents;
    }
}