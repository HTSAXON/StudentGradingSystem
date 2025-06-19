using StudentGradingSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradingSystem.DTO;
using StudentGradingSystem.GUI;

namespace StudentGradingSystem.BL
{
    public class AdminBl
    {
        private UserDto userDto {  get; set; }
        public AdminBl(UserDto user) {

            this.userDto = user;
        }

        public Form ReslutsForm()
        {
            return new AdminViewCoursesForm();
        }

    }
}
