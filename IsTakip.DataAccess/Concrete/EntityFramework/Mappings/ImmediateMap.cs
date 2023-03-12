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
    public class ImmediateMap : IEntityTypeConfiguration<Immediate>
    {
        public void Configure(EntityTypeBuilder<Immediate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        }
    }
}
