using CreateMigrations.Application.Wrappers;
using CreateMigrations.Domain.Products.DTOs;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
