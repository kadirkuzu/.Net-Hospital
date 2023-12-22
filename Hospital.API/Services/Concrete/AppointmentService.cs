using Hospital.API.Repositories.Abstract;
using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Concrete
{
    public class AppointmentService : SQLRepository<Appointment> , IAppointmentService
    {
        public AppointmentService(HospitalDbContext context) : base(context)
        {
        }
    }
}
