using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class PriceListDetail : BaseEntity
    {
        public int PriceListId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }

        public PriceList PriceList { get; set; }
        public Product Product { get; set; }
    }
}
