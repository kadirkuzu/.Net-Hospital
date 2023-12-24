using Hospital.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Repositories.Concrete
{
    public class HospitalDbContext : IdentityDbContext<Admin>
    {
        public HospitalDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<WorkSchedule> WorkSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clinic>().HasData(SeedData.SeedClinics);
            modelBuilder.Entity<Department>().HasData(SeedData.SeedDepartments);
        }
    }
}
