using B2B.Backend.Core.UnitOfWorks;
using B2B.Backend.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly B2BDbContext _context;

        public UnitOfWork(B2BDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
