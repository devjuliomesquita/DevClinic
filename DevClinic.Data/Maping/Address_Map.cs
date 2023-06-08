using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DevClinic.Data.Maping
{
    public class Address_Map : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("tb_Address");
            builder.HasKey(a => a.UserId);
            builder
                .Property(a => a.CEP)
                .IsRequired()
                .HasColumnName("CEP")
                .HasColumnType("varchar(8)");
            builder
                .Property(a => a.Street)
                .IsRequired()
                .HasConversion(a => a.ToString(), a => a)
                .HasColumnName("Street")
                .HasColumnType("varchar(100)");
            builder
                .Property(a => a.Number)
                .HasConversion(a => a.ToString(), a => a)
                .HasColumnName("Number")
                .HasColumnType("varchar(10)");
            builder
                .Property(a => a.Complement)
                .HasConversion(a => a.ToString(), a => a)
                .HasColumnName("Complement")
                .HasColumnType("varchar(50)");
            builder
                .Property(a => a.City)
                .IsRequired()
                .HasConversion(a => a.ToString(), a => a)
                .HasColumnName("City")
                .HasColumnType("varchar(50)");
            builder
                .Property(a => a.State)
                .IsRequired()
                .HasConversion(a => a.ToString(), a => a)
                .HasColumnName("State")
                .HasColumnType("varchar(50)");
            builder
                .HasOne(a => a.User)
                .WithOne(a => a.Address)
                .HasForeignKey<Address>(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
