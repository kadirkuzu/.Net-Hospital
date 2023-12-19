using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Concrete
{
    public class DepartmentService : SQLRepository<Department> , IDepartmentService
    {
        public DepartmentService(HospitalDbContext context) : base(context)
        {
        }
    }
}
