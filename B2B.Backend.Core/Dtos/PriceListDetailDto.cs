using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class PriceListDetailDto : BaseDto
    {
        public decimal Price { get; set; }

        public int PriceListId { get; set; }
        public int ProductId { get; set; }
    }
}
