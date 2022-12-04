using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class OperationClaim : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
