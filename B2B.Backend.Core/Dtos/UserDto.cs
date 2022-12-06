using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
