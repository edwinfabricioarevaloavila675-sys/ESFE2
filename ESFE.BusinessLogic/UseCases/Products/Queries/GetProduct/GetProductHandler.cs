using ESFE.BusinessLogic.DTOs;
using ESFE.DataAccess.Interfaces;
using ESFE.DataAccess.Repositories;
using ESFE.Entities;
using Mapster;
using MediatR;

namespace ESFE.BusinessLogic.UseCases.Products.Queries.GetProduct;

internal sealed class GetProductHandler(IEfRepository<Product> repository) : IRequestHandler<GetProductQuery,ProductByIdResponse>
{
    public async Task<ProductByIdResponse> Handle(GetProductQuery query, CancellationToken cancellationToken)
    {
        
        var product = await repository.GetByIdAsync(query.ProductId, cancellationToken);

        
        if (product is null)
        {
            return new ProductByIdResponse();
        }

        
        return product.Adapt< ProductByIdResponse>();
    }
}