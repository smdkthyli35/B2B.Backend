using B2B.Backend.Core.Entities;
using B2B.Backend.Core.Repositories;
using B2B.Backend.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Repository.Repositories
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(B2BDbContext context) : base(context)
        {
        }
    }
}
