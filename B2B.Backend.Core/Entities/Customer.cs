using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public ICollection<Basket> Baskets { get; set; }
        public ICollection<CustomerRelationship> CustomerRelationships { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
