using ESFE.BusinessLogic.DTOs;
using ESFE.BusinessLogic.UseCases.Products.Specifications;
using ESFE.DataAccess.Interfaces;
using ESFE.DataAccess.Repositories;
using ESFE.Entities;
using Mapster;
using MediatR;

namespace ESFE.BusinessLogic.UseCases.Products.Queries.GetProducts;

internal sealed class GetProductsHandler(IEfRepository<Product> repository)
    : IRequestHandler<GetProductsQuery, List<ProductResponse>>
{
    public async Task<List<ProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        
        var products = await repository.ListAsync(new GetProductWithBrandSpec(), cancellationToken);

        
        if (products is not { Count: > 0 })
        {
            return []; 
        }

        return products.Adapt<List<ProductResponse>>();
    }
}