using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradingSystem.DTO;
using StudentGradingSystem.GUI;
//using StudentGradingSystem.DL;

namespace StudentGradingSystem.BL
{
    public class FacultyBl
    {
        private UserDto userDto {  get; set; }
        public FacultyBl(UserDto userDto)
        {
            this.userDto = userDto;
        }

        public Form GradingRule()
        {
            //throw new NotImplementedException();

            return new FacultyRulesForm();
        }

        public Form CoursesForm()
        {
            return new FacultyCoursesForm();
        }
    }
}
