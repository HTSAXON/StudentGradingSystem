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
    public partial class FacultyDashboardForm : Form
    {
        private UserDto userDto { get; set; }
        private FacultyBl facultyBl { get; set; }
        public FacultyDashboardForm(UserDto userDto)
        {
            InitializeComponent();
            this.userDto = userDto;
            this.facultyBl = new FacultyBl(userDto);
        }

        private void FacultyDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FacultyDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Owner.Close();
        }

        private void btnViewGradingRules_Click(object sender, EventArgs e)
        {
            Form form = facultyBl.GradingRule();
            form.ShowDialog();

        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            Form form = facultyBl.CoursesForm();
            form.ShowDialog();
        }
    }
}
