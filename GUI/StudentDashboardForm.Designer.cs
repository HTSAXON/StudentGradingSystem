namespace StudentGradingSystem.GUI
{
    partial class StudentDashboardForm
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
            btnViewCourses = new Button();
            SuspendLayout();
            // 
            // btnViewCourses
            // 
            btnViewCourses.BackColor = Color.SlateGray;
            btnViewCourses.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewCourses.ForeColor = SystemColors.ButtonFace;
            btnViewCourses.Location = new Point(148, 376);
            btnViewCourses.Margin = new Padding(4);
            btnViewCourses.Name = "btnViewCourses";
            btnViewCourses.Size = new Size(781, 98);
            btnViewCourses.TabIndex = 0;
            btnViewCourses.Text = "View Courses";
            btnViewCourses.UseVisualStyleBackColor = false;
            btnViewCourses.Click += btnViewCourses_Click;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 588);
            Controls.Add(btnViewCourses);
            Margin = new Padding(4);
            Name = "StudentDashboardForm";
            Text = "StudentDashboardForm";
            FormClosed += StudentDashboardForm_FormClosed;
            Load += StudentDashboardForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCourses;
    }
}