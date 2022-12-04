using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class Basket : BaseEntity
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
