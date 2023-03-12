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
    public class MissionMap : IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasColumnType("ntext");
        }
    }
}
