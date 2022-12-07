using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class PriceListDetailUpdateDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public int PriceListId { get; set; }
    }
}
