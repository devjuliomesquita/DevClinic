using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Maping
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("tb_Doctor");
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");
            builder
                .Property(x => x.CPF)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("CPF")
                .HasColumnType("varchar(11)");
            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");
            builder
                .Property(x => x.Phone)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Phone")
                .HasColumnType("varchar(11)");
            builder
                .Property(x => x.Sexo)
                .IsRequired()
                .HasColumnName("Sexo")
                .HasColumnType("varchar(1)");
            builder
                .Property(x => x.Register)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Register")
                .HasColumnType("varchar(6)");
            //Relacionamento entre tabelas
            builder
                .HasMany(x => x.Specialities)
                .WithOne()
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
