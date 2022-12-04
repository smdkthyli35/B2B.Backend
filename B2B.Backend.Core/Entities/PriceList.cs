using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class PriceList : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<CustomerRelationship> CustomerRelationships { get; set; }
        public ICollection<PriceListDetail> PriceListDetails { get; set; }
    }
}
