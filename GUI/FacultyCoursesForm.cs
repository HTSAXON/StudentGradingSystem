using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentGradingSystem.DTO;
using StudentGradingSystem.BL;

namespace StudentGradingSystem.GUI
{
    public partial class FacultyCoursesForm : Form
    {
        public FacultyCoursesForm()
        {
            InitializeComponent();
            //gridCourses.Columns.Clear(); 
            this.btns();
            gridCourses.CellContentClick += gridCourses_CellContentClick;
            this.seed();
        }

        public void btns()
        {
            if (gridCourses.Columns["btnApprove"] == null)
            {
                var approveBtn = new DataGridViewButtonColumn
                {
                    Name = "btnApprove",
                    HeaderText = "",
                    Text = "Approve",
                    UseColumnTextForButtonValue = true
                };
                gridCourses.Columns.Add(approveBtn);
            }

            if (gridCourses.Columns["btnReject"] == null)
            {
                var rejectBtn = new DataGridViewButtonColumn
                {
                    Name = "btnReject",
                    HeaderText = "",
                    Text = "Reject",
                    UseColumnTextForButtonValue = true
                };
                gridCourses.Columns.Add(rejectBtn);
            }

            if (gridCourses.Columns["btnViewStudents"] == null)
            {
                var viewBtn = new DataGridViewButtonColumn
                {
                    Name = "btnViewStudents",
                    HeaderText = "",
                    Text = "View Students",
                    UseColumnTextForButtonValue = true
                };
                gridCourses.Columns.Add(viewBtn);
            }
        }

        public void seed()
        {

            List<CourseDto> courses = new List<CourseDto>();

            courses.Add(new CourseDto()
            {
                CourseId = 1,
                Course = "Machin Learning",
                Status = "Pending"
            });
            courses.Add(new CourseDto()
            {
                CourseId = 2,
                Course = "NLP",
                Status = "Pending"
            });
            BindingSource binding = new BindingSource();
            binding.DataSource = courses;

            //bind datagridview to binding source
            gridCourses.DataSource = binding;

        }
        private void gridCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            var course = (CourseDto)grid.Rows[e.RowIndex].DataBoundItem;

            string columnName = grid.Columns[e.ColumnIndex].Name;

            if (columnName == "btnApprove")
            {
                MessageBox.Show($"Approved Course ID: {course.CourseId}");
                // Update course status or trigger logic
            }
            else if (columnName == "btnReject")
            {
                MessageBox.Show($"Rejected Course ID: {course.CourseId}");
                // Update course status or trigger logic
            }
            else if (columnName == "btnViewStudents")
            {
                MessageBox.Show($"Viewing Students for Course ID: {course.CourseId}");
                // Navigate to student list or show modal
            }
        }
    }
}
