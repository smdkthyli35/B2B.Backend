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
    public class PriceListConfiguration : BaseEntityConfiguration<PriceList>
    {
        public override void Configure(EntityTypeBuilder<PriceList> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.ToTable("PriceLists");
        }
    }
}
