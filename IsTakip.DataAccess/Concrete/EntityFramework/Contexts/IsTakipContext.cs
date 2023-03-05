using IsTakip.DataAccess.Concrete.EntityFramework.Mappings;
using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Contexts
{
    public class IsTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=IGU-NB-0884;initial catalog=IsTakipDB;user id=sa;password=s123456*-;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkingMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
        public DbSet<Working> Workings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
