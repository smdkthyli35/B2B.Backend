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
    public class EmailParameterRepository : GenericRepository<EmailParameter>, IEmailParameterRepository
    {
        public EmailParameterRepository(B2BDbContext context) : base(context)
        {
        }
    }
}
