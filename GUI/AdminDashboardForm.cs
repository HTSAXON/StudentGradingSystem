using StudentGradingSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentGradingSystem.BL;

namespace StudentGradingSystem.GUI
{
    public partial class AdminDashboardForm : Form
    {
        private UserDto userDto { get; set; }
        private AdminBl adminBl { get; set; }
        public AdminDashboardForm(UserDto user)
        {
            InitializeComponent();
            userDto = user;
            adminBl = new AdminBl(userDto);
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Owner.Close();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            Form form = adminBl.ReslutsForm();
            form.ShowDialog();

        }
    }
}
