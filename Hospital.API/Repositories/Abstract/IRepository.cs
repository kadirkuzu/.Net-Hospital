using Hospital.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Repositories.Abstract
{
    public interface IRepository<IEntity> where IEntity : BaseEntity
    {
        DbSet<IEntity> Table { get; }
    }
}
