namespace StudentGradingSystem
{
    partial class StudentAssessmentForm
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
            Assessment = new DataGridViewTextBoxColumn();
            TotalMarks = new DataGridViewTextBoxColumn();
            ObtainedMarks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Assessment, TotalMarks, ObtainedMarks });
            dataGridView1.Location = new Point(17, 33);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 416);
            dataGridView1.TabIndex = 0;
            // 
            // Assessment
            // 
            Assessment.FillWeight = 200F;
            Assessment.HeaderText = "Assessment";
            Assessment.MinimumWidth = 6;
            Assessment.Name = "Assessment";
            Assessment.Width = 300;
            // 
            // TotalMarks
            // 
            TotalMarks.FillWeight = 200F;
            TotalMarks.HeaderText = "Total Marks";
            TotalMarks.MinimumWidth = 6;
            TotalMarks.Name = "TotalMarks";
            TotalMarks.Width = 200;
            // 
            // ObtainedMarks
            // 
            ObtainedMarks.FillWeight = 200F;
            ObtainedMarks.HeaderText = "Obtained Marks";
            ObtainedMarks.MinimumWidth = 6;
            ObtainedMarks.Name = "ObtainedMarks";
            ObtainedMarks.Width = 200;
            // 
            // StudentAssessmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 588);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudentAssessmentForm";
            Text = "StudentAssessmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Assessment;
        private DataGridViewTextBoxColumn TotalMarks;
        private DataGridViewTextBoxColumn ObtainedMarks;
    }
}