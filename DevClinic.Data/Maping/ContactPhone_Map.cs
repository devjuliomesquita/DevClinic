using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevClinic.Data.Maping
{
    public class ContactPhone_Map : IEntityTypeConfiguration<ContactPhone>
    {
        public void Configure(EntityTypeBuilder<ContactPhone> builder)
        {
            builder.ToTable("tb_ContactPhone");
            builder.HasKey(c => new { c.ClientId, c.Phone });
            builder
                .Property(c => c.Phone)
                .HasConversion(c => c.ToString(), c => c)
                .HasColumnName("Phone")
                .HasColumnType("varchar(11)");
            
        }
    }
}
