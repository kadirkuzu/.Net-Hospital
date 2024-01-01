using Hospital.API.Repositories.Concrete;
using Hospital.API.Services.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Concrete
{
    public class WorkScheduleService : SQLRepository<WorkSchedule>, IWorkScheduleService
    {
        public WorkScheduleService(HospitalDbContext context) : base(context)
        {
        }
    }
}
