namespace StudentGradingSystem.GUI
{
    partial class FacultyDashboardForm
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
            button1 = new Button();
            selectBatch = new ComboBox();
            selectSemester = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(550, 293);
            button1.Name = "button1";
            button1.Size = new Size(301, 64);
            button1.TabIndex = 0;
            button1.Text = "View Courses";
            button1.UseVisualStyleBackColor = true;
            // 
            // selectBatch
            // 
            selectBatch.FormattingEnabled = true;
            selectBatch.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            selectBatch.Location = new Point(550, 109);
            selectBatch.Name = "selectBatch";
            selectBatch.Size = new Size(298, 25);
            selectBatch.TabIndex = 1;
            // 
            // selectSemester
            // 
            selectSemester.FormattingEnabled = true;
            selectSemester.Items.AddRange(new object[] { "F2022", "S2022", "F2023", "S2023", "F2024", "S2024", "F2025", "S2025" });
            selectSemester.Location = new Point(550, 169);
            selectSemester.Name = "selectSemester";
            selectSemester.Size = new Size(298, 25);
            selectSemester.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 89);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 3;
            label1.Text = "Select Semester";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 149);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 4;
            label2.Text = "Select Batch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 211);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 6;
            label3.Text = "Select Program";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BSSE", "BSCS", "BSAI", "BSIT", "BBA" });
            comboBox1.Location = new Point(553, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 25);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Arial", 36F);
            label4.Location = new Point(31, 30);
            label4.Name = "label4";
            label4.Size = new Size(279, 67);
            label4.TabIndex = 7;
            label4.Text = "Welcome";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 404);
            button2.Name = "button2";
            button2.Size = new Size(236, 47);
            button2.TabIndex = 8;
            button2.Text = "View Grading Rules";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(521, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 339);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // FacultyDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 463);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectSemester);
            Controls.Add(selectBatch);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Name = "FacultyDashboardForm";
            Text = "Faculty Dashboard";
            Load += FacultyDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox selectBatch;
        private ComboBox selectSemester;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button2;
        private GroupBox groupBox1;
    }
}