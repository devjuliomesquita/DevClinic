using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevClinic.Data.Maping
{
    public class ContactEmail_Map : IEntityTypeConfiguration<ContactEmail>
    {
        public void Configure(EntityTypeBuilder<ContactEmail> builder)
        {
            builder.ToTable("tb_ContactEmail");
            builder.HasKey(c => new { c.ClientId, c.Email});
            builder
                .Property(c => c.Email)
                .HasConversion(c => c.ToString(), c => c)
                .HasColumnName("Email")
                .HasColumnType("varchar(50)");
        }
    }
}
