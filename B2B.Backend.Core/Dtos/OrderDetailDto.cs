using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class OrderDetailDto : BaseDto
    {
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
