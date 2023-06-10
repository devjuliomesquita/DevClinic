using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DevClinic.Data.Maping
{
    public class Client_Map : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("tb_Clients");
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
                .Property(x => x.Sexo)
                .IsRequired()
                .HasColumnName("Sexo")
                .HasColumnType("varchar(1)");
            builder
                .Property(x => x.Register)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Register")
                .HasColumnType("varchar(50)");
            builder
                .Property(x => x.Plan)
                .IsRequired()
                .HasConversion(x => x.ToString(), x => x)
                .HasColumnName("Plan")
                .HasColumnType("varchar(20)");

            
        }
    }
}
