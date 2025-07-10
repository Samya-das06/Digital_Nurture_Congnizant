using System.Threading.Tasks;
using CreateMigrations.Application.DTOs;
using CreateMigrations.Domain.Products.DTOs;
using CreateMigrations.Domain.Products.Entities;

namespace CreateMigrations.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
