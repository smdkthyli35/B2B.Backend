using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Dtos
{
    public class ProductImageDto : BaseDto
    {
        public string ImageUrl { get; set; }

        public int ProductId { get; set; }
    }
}
