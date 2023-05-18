using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Maping
{
    public class SpecialityMap : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.ToTable("tb_Speciality");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameSpeciality)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Speciality")
                .HasColumnType("varchar(100)");
        }
    }
}
