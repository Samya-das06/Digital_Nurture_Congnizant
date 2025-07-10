using System.Threading;
using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.Helpers;
using DatabaseContextRetailStore1.Application.Interfaces;
using DatabaseContextRetailStore1.Application.Interfaces.Repositories;
using DatabaseContextRetailStore1.Application.Wrappers;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteProductCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            productRepository.Delete(product);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}
