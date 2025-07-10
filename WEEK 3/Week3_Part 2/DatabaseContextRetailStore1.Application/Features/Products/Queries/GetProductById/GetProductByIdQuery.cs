using DatabaseContextRetailStore1.Application.Wrappers;
using DatabaseContextRetailStore1.Domain.Products.DTOs;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
