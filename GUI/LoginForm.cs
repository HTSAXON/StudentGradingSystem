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
using StudentGradingSystem.DTO;

namespace StudentGradingSystem.GUI
{
    public partial class LoginForm : Form
    {
        public LoginBl loginBl { get; set; }
        public LoginDto loginDto { get; set; }
        private UserDto? userDto { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginBl = new LoginBl();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = this.inputUserName.Text;
            string pswd = this.inputPassword.Text;
            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pswd)) {
                MessageBox.Show("Fill All Fields!");
            }
            else
            {
                LoginDto loginDto = new LoginDto();
                loginDto.UserName = uname;
                loginDto.Password = pswd;

                Form? form = loginBl.login(loginDto, this);

                if (form == null) { 
                    MessageBox.Show("Username or Password is wrong, TryAgain!");
                }
                else
                {
                    //MessageBox.Show("Good");
                    form.ShowDialog();
                    //this.Hide();
                }

            }
        }
    }
}
