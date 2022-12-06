using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class OrderDto : BaseDto
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public int CustomerId { get; set; }
    }
}
