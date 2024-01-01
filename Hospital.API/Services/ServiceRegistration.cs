using Microsoft.EntityFrameworkCore;
using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.API.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Hospital.Models;

namespace Hospital.API.Services
{
    public static class ServiceRegistration
    {
        public static void AddHospitalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<HospitalUser, IdentityRole>()
                .AddEntityFrameworkStores<HospitalDbContext>()
                .AddDefaultTokenProviders();


            services.AddDbContext<HospitalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            services.AddScoped<IDoctorService,DoctorService>();
            services.AddScoped<IClinicService,ClinicService>();
            services.AddScoped<IDepartmentService,DepartmentService>();
            services.AddScoped<IAppointmentService,AppointmentService>();
            services.AddScoped<IWorkScheduleService,WorkScheduleService>();

        }
        public static async Task InitializeRolesAsync(IServiceProvider serviceProvider)
        {
            using var serviceScope = serviceProvider.CreateScope();
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Define your roles here
            var roles = new[] { "Patient", "Admin" };

            foreach (var role in roles)
            {
                var roleExists = await roleManager.RoleExistsAsync(role);

                if (!roleExists)
                {
                    // Create the role if it doesn't exist
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
