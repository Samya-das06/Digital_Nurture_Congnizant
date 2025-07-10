using System.Threading.Tasks;

namespace CreateMigrations.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
