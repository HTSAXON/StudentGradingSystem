namespace StudentGradingSystem.GUI
{
    partial class AdminDashboardForm
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
            btnViewResults = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 54);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // btnViewResults
            // 
            btnViewResults.Font = new Font("Microsoft Tai Le", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResults.Location = new Point(338, 381);
            btnViewResults.Margin = new Padding(4);
            btnViewResults.Name = "btnViewResults";
            btnViewResults.Size = new Size(385, 85);
            btnViewResults.TabIndex = 1;
            btnViewResults.Text = "View Results";
            btnViewResults.UseVisualStyleBackColor = true;
            btnViewResults.Click += btnViewResults_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 588);
            Controls.Add(btnViewResults);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard";
            FormClosed += AdminDashboardForm_FormClosed;
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewResults;
    }
}

