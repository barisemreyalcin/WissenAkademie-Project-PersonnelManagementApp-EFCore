using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personnel.EFCore.Domain;

namespace Personnel.EFCore.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer 
                ("Data Source=DESKTOP-6QTPFUC;Initial Catalog=PersonnelDB;User Id=sa;Password=mssqlserverbey;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonnelDetailMappingConfig().Configure(modelBuilder.Entity<PersonnelDetail>());
            new PersonnelMappingConfig().Configure(modelBuilder.Entity<Personnel.EFCore.Domain.Personnel>());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Personnel.EFCore.Domain.Personnel> Personnels { get; set; }
        public DbSet<PersonnelDetail> PersonnelDetails { get; set; }
    }
}
