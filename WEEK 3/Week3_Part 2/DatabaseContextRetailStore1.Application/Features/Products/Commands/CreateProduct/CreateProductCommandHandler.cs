using System.Threading;
using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.Interfaces;
using DatabaseContextRetailStore1.Application.Interfaces.Repositories;
using DatabaseContextRetailStore1.Application.Wrappers;
using DatabaseContextRetailStore1.Domain.Products.Entities;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
