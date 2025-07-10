using System.Threading;
using System.Threading.Tasks;
using CreateMigrations.Application.Interfaces.Repositories;
using CreateMigrations.Application.Wrappers;
using CreateMigrations.Domain.Products.DTOs;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
