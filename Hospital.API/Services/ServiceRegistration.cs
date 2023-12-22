using Microsoft.EntityFrameworkCore;
using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.API.Services.Concrete;

namespace Hospital.API.Services
{
    public static class ServiceRegistration
    {
        public static void AddHospitalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            services.AddScoped<IDoctorService,DoctorService>();
            services.AddScoped<IClinicService,ClinicService>();
            services.AddScoped<IDepartmentService,DepartmentService>();
            services.AddScoped<IAppointmentService,AppointmentService>();
        }
    }
}
