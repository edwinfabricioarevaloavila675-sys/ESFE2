using ESFE.DataAccess.Interfaces;
using ESFE.DataAccess.Repositories;
using ESFE.Entities;
using Mapster;
using MediatR;

namespace ESFE.BusinessLogic.UseCases.Products.Commands.UpdateProduct;

internal sealed class UpdateProductHandler(EfRepository<Product> repository) : IRequestHandler<UpdateProductCommand, long>
{
    public async Task<long> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        try
        {
           
            var existingProduct = await repository.GetByIdAsync(command.Request.ProductId, cancellationToken);

           
            if (existingProduct is null) return 0;

           
            command.Request.Adapt(existingProduct);

            await repository.UpdateAsync(existingProduct, cancellationToken);

            return existingProduct.ProductId;
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
