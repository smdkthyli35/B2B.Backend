using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
