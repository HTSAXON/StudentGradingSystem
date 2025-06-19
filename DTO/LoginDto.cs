using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem.DTO
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Copy(LoginDto loginDto)
        {
            this.UserName = loginDto.UserName;
            this.Password = loginDto.Password;
        }
    }
}
