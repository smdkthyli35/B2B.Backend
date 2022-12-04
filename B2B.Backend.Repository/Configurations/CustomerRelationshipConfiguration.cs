using B2B.Backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Repository.Configurations
{
    public class CustomerRelationshipConfiguration : BaseEntityConfiguration<CustomerRelationship>
    {
        public override void Configure(EntityTypeBuilder<CustomerRelationship> builder)
        {
            builder.Property(x => x.Discount).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Customer).WithMany(x => x.CustomerRelationships).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.PriceList).WithMany(x => x.CustomerRelationships).HasForeignKey(x => x.PriceListId);

            builder.ToTable("CustomerRelationships");
        }
    }
}
