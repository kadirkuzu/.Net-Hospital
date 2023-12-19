using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Concrete
{
    public class ClinicService : SQLRepository<Clinic>,  IClinicService
    {
        public ClinicService(HospitalDbContext context) : base(context)
        {
        }
    }
}
