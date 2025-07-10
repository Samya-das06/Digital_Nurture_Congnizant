using System.Threading.Tasks;

namespace DatabaseContextRetailStore1.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
