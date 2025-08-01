using System.Threading;
using System.Threading.Tasks;
using CreateMigrations.Application.Helpers;
using CreateMigrations.Application.Interfaces;
using CreateMigrations.Application.Interfaces.Repositories;
using CreateMigrations.Application.Wrappers;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<UpdateProductCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            product.Update(request.Name, request.Price, request.BarCode);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}
