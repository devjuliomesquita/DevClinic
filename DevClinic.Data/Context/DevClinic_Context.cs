using DevClinic.Data.Maping;
using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace DevClinic.Data.Context
{
    public class DevClinic_Context : DbContext
    {
        public DevClinic_Context(DbContextOptions<DevClinic_Context> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>( new ClientMap().Configure);
        }
    }
}
