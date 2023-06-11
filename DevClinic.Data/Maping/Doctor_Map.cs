using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DevClinic.Data.Maping
{
    public class Doctor_Map : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("tb_Doctors");
            builder.HasKey(d => d.Id);
            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasConversion(d => d.ToString(), d => d)
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");
            builder
                .Property(d => d.CPF)
                .IsRequired()
                .HasConversion(d => d.ToString(), d => d)
                .HasColumnName("CPF")
                .HasColumnType("varchar(11)");
            builder
                .Property(d => d.Sexo)
                .IsRequired()
                .HasColumnName("Sexo")
                .HasColumnType("varchar(1)");
            builder
                .Property(d => d.CRM)
                .IsRequired()
                .HasColumnName("CRM")
                .HasColumnType("varchar(13)");
            builder
                .HasMany(s => s.Specialities)
                .WithMany(d => d.Doctors)
                .UsingEntity<DoctorSpeciality>(
                    ds => ds.HasOne(s => s.Specialities).WithMany().HasForeignKey(s =>s.SpecialityId),
                    ds => ds.HasOne(d => d.Doctors).WithMany().HasForeignKey(d => d.DoctorId),
                    ds =>
                    {
                        ds.ToTable("tb_DoctorsSpecialities");
                        ds.HasKey(ds => new { ds.DoctorId, ds.SpecialityId });
                        ds.Property(s => s.SpecialityId).HasColumnName("id_speciality").IsRequired();
                        ds.Property(d => d.DoctorId).HasColumnName("id_doctor").IsRequired();
                    }
                );

        }
    }
}
