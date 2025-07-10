using DatabaseContextRetailStore1.Application.Wrappers;
using MediatR;

namespace DatabaseContextRetailStore1.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
