using IsTakip.DataAccess.Concrete.EntityFramework.Mappings;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Contexts
{
    //public class IsTakipContext : DbContext
    public class IsTakipContext : IdentityDbContext<AppUser,AppRole,int>
        // burada kullanılacak user tablosu ve role tabloları ve primary key değerlerini burada ayalamamız gerekiyor
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=IGU-NB-0884;initial catalog=IsTakipAppDB;user id=sa;password=s123456*-;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new MissionMap());
            modelBuilder.ApplyConfiguration(new ImmediateMap());
            modelBuilder.ApplyConfiguration(new ReportMap());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Mission> Missions { get; set; } // Görevler
        public DbSet<Immediate> Immediates { get; set; } // Aciliyet Durumları

        public DbSet<Report> Reports { get; set; } // Raporlar

    }
}
