using ESFE.BusinessLogic.DTOs;
using MediatR;

namespace ESFE.BusinessLogic.UseCases.Products.Queries.GetProduct;

public record GetProductQuery(long ProductId) : IRequest<ProductByIdResponse>;
