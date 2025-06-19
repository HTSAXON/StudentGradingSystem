using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using StudentGradingSystem.DTO;
using StudentGradingSystem.GUI;

namespace StudentGradingSystem.BL
{
    public class LoginBl
    {
        public Form boot()
        {
            return new LoginForm();
        }

        public Form? login(LoginDto loginDto, LoginForm form)
        {
            if (loginDto != null) {
                UserDto userDto = new UserDto(loginDto);
                Form dashboardForm;

                if (loginDto.UserName == "st1" && loginDto.Password == "0000")
                {
                    userDto.Role = "student";
                    dashboardForm = new StudentDashboardForm(userDto);
                    dashboardForm.Owner = form;
                    return dashboardForm;
                }
                else if (loginDto.UserName == "fac1" && loginDto.Password == "0000") 
                { 
                    userDto.Role = "faculty";
                    dashboardForm = new FacultyDashboardForm(userDto);
                    dashboardForm.Owner = form;
                    return dashboardForm;
                }
                else if (loginDto.UserName == "admin" && loginDto.Password == "0000")
                {
                    userDto.Role = "admin";
                    dashboardForm = new AdminDashboardForm(userDto);
                    dashboardForm.Owner = form;
                    return dashboardForm;
                }
            }

            return null;
        }
    }
}
