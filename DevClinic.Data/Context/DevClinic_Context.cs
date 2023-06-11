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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactEmail> ContactEmails { get; set; }
        public DbSet<ContactPhone> ContactPhones { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<DoctorSpeciality> DoctorsSpecialities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>( new Client_Map().Configure);
            modelBuilder.Entity<Address>( new Address_Map().Configure);
            modelBuilder.Entity<ContactEmail>( new ContactEmail_Map().Configure);
            modelBuilder.Entity<ContactPhone>(new ContactPhone_Map().Configure);
            modelBuilder.Entity<Doctor>(new Doctor_Map().Configure);
            modelBuilder.Entity<Speciality>(new Speciality_Map().Configure);
        }
    }
}
