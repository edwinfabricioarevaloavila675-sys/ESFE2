using ESFE.BusinessLogic.DTOs;
using ESFE.Entities;
using Mapster;

namespace ESFE.BusinessLogic.Mappings;

public class MappingRegister : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductResponse>()
            .Map(dest => dest.BrandName, src => src.Brand.BrandName);

        
    }
}
