using System.Threading;
using System.Threading.Tasks;
using CreateMigrations.Application.Helpers;
using CreateMigrations.Application.Interfaces;
using CreateMigrations.Application.Interfaces.Repositories;
using CreateMigrations.Application.Wrappers;
using CreateMigrations.Domain.Products.DTOs;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryHandler(IProductRepository productRepository, ITranslator translator) : IRequestHandler<GetProductByIdQuery, BaseResult<ProductDto>>
    {
        public async Task<BaseResult<ProductDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            return new ProductDto(product);
        }
    }
}
