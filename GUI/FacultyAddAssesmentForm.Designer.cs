namespace StudentGradingSystem.GUI
{
    partial class FacultyAddAssesmentForm
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
            label1 = new Label();
            inputAssesment = new TextBox();
            label2 = new Label();
            label3 = new Label();
            inputTotalMarks = new NumericUpDown();
            inputObtainedMarks = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputTotalMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputObtainedMarks).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(420, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 1;
            label1.Text = "Assesment Name";
            label1.Click += label1_Click;
            // 
            // inputAssesment
            // 
            inputAssesment.Location = new Point(199, 61);
            inputAssesment.Name = "inputAssesment";
            inputAssesment.Size = new Size(315, 25);
            inputAssesment.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 167);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 3;
            label2.Text = "Obtained Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 117);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 4;
            label3.Text = "Total Marks";
            // 
            // inputTotalMarks
            // 
            inputTotalMarks.Location = new Point(198, 114);
            inputTotalMarks.Name = "inputTotalMarks";
            inputTotalMarks.Size = new Size(316, 25);
            inputTotalMarks.TabIndex = 5;
            // 
            // inputObtainedMarks
            // 
            inputObtainedMarks.Location = new Point(199, 167);
            inputObtainedMarks.Name = "inputObtainedMarks";
            inputObtainedMarks.Size = new Size(316, 25);
            inputObtainedMarks.TabIndex = 6;
            // 
            // FacultyAddAssesmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 287);
            Controls.Add(inputObtainedMarks);
            Controls.Add(inputTotalMarks);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputAssesment);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FacultyAddAssesmentForm";
            Text = "FacultyAddAssesmentForm";
            ((System.ComponentModel.ISupportInitialize)inputTotalMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputObtainedMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox inputAssesment;
        private Label label2;
        private Label label3;
        private NumericUpDown inputTotalMarks;
        private NumericUpDown inputObtainedMarks;
    }
}