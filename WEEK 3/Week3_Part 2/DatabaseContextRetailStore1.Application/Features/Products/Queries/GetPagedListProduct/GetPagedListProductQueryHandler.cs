using System.Threading;
using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.Interfaces.Repositories;
using DatabaseContextRetailStore1.Application.Wrappers;
using DatabaseContextRetailStore1.Domain.Products.DTOs;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
