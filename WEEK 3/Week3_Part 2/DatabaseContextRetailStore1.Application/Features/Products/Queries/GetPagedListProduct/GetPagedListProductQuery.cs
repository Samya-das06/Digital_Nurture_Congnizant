using DatabaseContextRetailStore1.Application.Parameters;
using DatabaseContextRetailStore1.Application.Wrappers;
using DatabaseContextRetailStore1.Domain.Products.DTOs;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
