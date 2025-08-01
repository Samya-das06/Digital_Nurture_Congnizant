using System.Threading.Tasks;

namespace DatabaseContextRetailStore1.Application.Interfaces
{
    public interface IFileManagerService
    {
        Task Create(string name, byte[] content);
        Task Update(string name, byte[] content);
        Task<byte[]> Download(string name);
        Task Delete(string name);
        Task<int> SaveChangesAsync();
    }

}
