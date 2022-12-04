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
    public class PriceListDetailConfiguration : BaseEntityConfiguration<PriceListDetail>
    {
        public override void Configure(EntityTypeBuilder<PriceListDetail> builder)
        {
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.PriceList).WithMany(x => x.PriceListDetails).HasForeignKey(x => x.PriceListId);
            builder.HasOne(x => x.Product).WithMany(x => x.PriceListDetails).HasForeignKey(x => x.ProductId);

            builder.ToTable("PriceListDetails");
        }
    }
}
