using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.DTOs;
using DatabaseContextRetailStore1.Domain.Products.DTOs;
using DatabaseContextRetailStore1.Domain.Products.Entities;

namespace DatabaseContextRetailStore1.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
