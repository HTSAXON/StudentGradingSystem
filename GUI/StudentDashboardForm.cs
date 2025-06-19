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
using Microsoft.VisualBasic.ApplicationServices;

namespace StudentGradingSystem.GUI
{
    public partial class StudentDashboardForm : Form
    {
        private UserDto userDto { get; set; }
        private StudentBl studentBl { get; set; }

        public StudentDashboardForm(UserDto user)
        {
            InitializeComponent();
            userDto = user;
            StudentBl studentBl =  new StudentBl(userDto);
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void StudentDashboardForm_FormClosed(object sender, FormClosedEventArgs e) => Owner.Close();


        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            Form form = studentBl.CourseForm();
            form.ShowDialog();
        }

     
    }
}
