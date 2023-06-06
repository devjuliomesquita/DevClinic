using DevClinic.Data.Maping;
using DevClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DbSet<Doctor_Speciality> Doctor_Speciality { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>( new ClientMap().Configure);
        }
    }
}
