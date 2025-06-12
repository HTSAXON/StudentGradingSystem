namespace StudentGradingSystem
{
    partial class StudentCourseForm
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
            button1 = new Button();
            CourseName = new DataGridViewTextBoxColumn();
            ObtainedMarks = new DataGridViewTextBoxColumn();
            TotalMarks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseName, ObtainedMarks, TotalMarks });
            dataGridView1.Location = new Point(17, 17);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 450);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(391, 531);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(348, 44);
            button1.TabIndex = 1;
            button1.Text = "View Assessment";
            button1.UseVisualStyleBackColor = true;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 300;
            // 
            // ObtainedMarks
            // 
            ObtainedMarks.HeaderText = "Obtained Marks";
            ObtainedMarks.MinimumWidth = 6;
            ObtainedMarks.Name = "ObtainedMarks";
            ObtainedMarks.Width = 200;
            // 
            // TotalMarks
            // 
            TotalMarks.HeaderText = "Total Marks";
            TotalMarks.MinimumWidth = 6;
            TotalMarks.Name = "TotalMarks";
            TotalMarks.Width = 200;
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 588);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudentCourseForm";
            Text = "StudentCourseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn ObtainedMarks;
        private DataGridViewTextBoxColumn TotalMarks;
    }
}