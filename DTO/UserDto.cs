using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem.DTO
{
    public class UserDto:LoginDto
    {
        public string Role { get; set; }
        public UserDto(LoginDto loginDto) {
            base.Copy(loginDto);
        }
    }
}
