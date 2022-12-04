using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class CustomerRelationship : BaseEntity
    {
        public int CustomerId { get; set; }
        public int PriceListId { get; set; }
        public decimal Discount { get; set; }

        public Customer Customer { get; set; }
        public PriceList PriceList { get; set; }
    }
}
