using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Concrete
{
    public class DoctorService : SQLRepository<Doctor> ,  IDoctorService
    {
        public DoctorService(HospitalDbContext context) : base(context)
        {
        }
    }
}
