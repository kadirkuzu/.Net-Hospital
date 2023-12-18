using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Data.Contexts
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalDepartment> MedicalDepartments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<WorkSchedule> WorkSchedules { get; set; }
    }
}
