using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class EmailParameterDto : BaseDto
    {
        public string Smtp { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
        public bool HTML { get; set; }
    }
}
