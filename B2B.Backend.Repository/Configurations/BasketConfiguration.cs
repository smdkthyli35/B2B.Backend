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
    public class BasketConfiguration : BaseEntityConfiguration<Basket>
    {
        public override void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.Property(x => x.Quantity).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Product).WithMany(x => x.Baskets).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Customer).WithMany(x => x.Baskets).HasForeignKey(x => x.CustomerId);

            builder.ToTable("Baskets");
        }
    }
}
