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
    public class OperationClaimConfiguration : BaseEntityConfiguration<OperationClaim>
    {
        public override void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);

            builder.ToTable("OperationClaims");
        }
    }
}
