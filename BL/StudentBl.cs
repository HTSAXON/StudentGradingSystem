using StudentGradingSystem.GUI;
using StudentGradingSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem.BL
{
    public class StudentBl
    {
        private UserDto userDto {  get; set; }
        public StudentBl(UserDto user) {
            userDto = user;
        }

        public Form CourseForm()
        {
            return new StudentCourseForm();
        }

        public Form AssessmentForm() { 
            return new StudentAssessmentForm();
        }
    }
}
