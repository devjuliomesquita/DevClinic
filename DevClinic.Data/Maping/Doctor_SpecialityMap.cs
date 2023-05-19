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
    public class Doctor_SpecialityMap : IEntityTypeConfiguration<Doctor_Speciality>
    {
        public void Configure(EntityTypeBuilder<Doctor_Speciality> builder)
        {
            builder.ToTable("tb_Doctor_Specility");
            builder.HasKey(ds => new {ds.SpecilityId, ds.DoctorId});
            builder
                .HasOne(ds => ds.Doctor)
                .WithMany(ds => ds.Specialities)
                .HasForeignKey(ds => ds.DoctorId);
            builder
                .HasOne(ds => ds.Speciality)
                .WithMany(ds => ds.Doctors)
                .HasForeignKey(ds => ds.SpecilityId);
        }
    }
}
