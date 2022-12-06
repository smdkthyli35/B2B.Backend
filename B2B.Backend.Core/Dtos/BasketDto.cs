using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class BasketDto : BaseDto
    {
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
