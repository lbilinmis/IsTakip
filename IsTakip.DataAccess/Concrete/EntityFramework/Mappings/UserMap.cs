using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasMaxLength(52).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(52);
            builder.Property(x => x.PhoneNumber).HasMaxLength(10);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(i => i.Workings)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);
        }
    }
}
