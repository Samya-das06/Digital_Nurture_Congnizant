using CreateMigrations.Application.Parameters;
using CreateMigrations.Application.Wrappers;
using CreateMigrations.Domain.Products.DTOs;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
