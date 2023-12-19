using Hospital.API.Repositories.Abstract;
using Hospital.Models;

namespace Hospital.API.Services.Abstract
{
    public interface IClinicService : ISQLRepository<Clinic>
    {
    }
}
