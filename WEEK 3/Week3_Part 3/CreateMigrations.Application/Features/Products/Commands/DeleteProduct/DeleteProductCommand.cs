using CreateMigrations.Application.Wrappers;
using MediatR;

namespace CreateMigrations.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
