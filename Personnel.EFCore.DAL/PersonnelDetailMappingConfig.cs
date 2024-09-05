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
    public class PersonnelDetailMappingConfig : IEntityTypeConfiguration<PersonnelDetail>
    {
        public void Configure(EntityTypeBuilder<PersonnelDetail> builder)
        {
            builder.ToTable("PersonnelDetail");

            builder.HasKey(pd => pd.PersonnelDetailID);

            builder.Property(pd => pd.PersonnelDetailID).IsRequired();
            builder.Property(pd => pd.Email).IsRequired().HasMaxLength(100);
            builder.Property(pd => pd.Phone).IsRequired().HasMaxLength(20);
            builder.Property(pd => pd.Address).IsRequired().HasMaxLength(200);
        }
    }
}
