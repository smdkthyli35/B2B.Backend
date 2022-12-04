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
    public class UserOperationClaimConfiguration : BaseEntityConfiguration<UserOperationClaim>
    {
        public override void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.OperationClaim).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.OperationClaimId);

            builder.ToTable("UserOperationClaims");
        }
    }
}
