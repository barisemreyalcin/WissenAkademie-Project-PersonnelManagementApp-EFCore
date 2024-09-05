using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personnel.EFCore.Domain;

namespace Personnel.EFCore.DAL
{
    public class PersonnelMappingConfig : IEntityTypeConfiguration<Personnel.EFCore.Domain.Personnel>
    {
        public void Configure(EntityTypeBuilder<Domain.Personnel> builder)
        {
            builder.ToTable("Personnel");

            builder.HasKey(p => p.PersonnelID);

            builder.Property(p => p.PersonnelID).IsRequired();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.IdentityNumber).IsRequired().HasMaxLength(11);
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
            builder.Property(p => p.Department).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();

            builder.HasOne(p => p.PersonnelDetail)
                .WithOne(pd => pd.Personnel)
                .HasForeignKey<PersonnelDetail>(pd => pd.PersonnelID);
        }
    }
}
