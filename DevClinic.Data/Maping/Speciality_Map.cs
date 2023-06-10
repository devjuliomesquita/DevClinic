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
    public class Speciality_Map : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.ToTable("tb_Specialities");
            builder.HasKey(x => x.Id);
            builder
                .Property(d => d.NameSpeciality)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(20)");
            builder
                .Property(d => d.DescriptionSpeciality)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar(300)");
        }
    }
}
