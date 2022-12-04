using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Basket> Baskets { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<PriceListDetail> PriceListDetails { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
