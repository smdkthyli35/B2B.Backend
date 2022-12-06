using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class CustomerRelationshipDto : BaseDto
    {
        public decimal Discount { get; set; }

        public int CustomerId { get; set; }
        public int PriceListId { get; set; }
    }
}
