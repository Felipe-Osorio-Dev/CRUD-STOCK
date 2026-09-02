using API.DTO.Requests;
using API.Models.Product;
using Mapster;

namespace API.Mappings.Product
{
    public static class ProductMappingConfig
    {
        public static void Register()
        {
            TypeAdapterConfig<PatchUpdateProductDTO, ProductModel>
                .NewConfig()
                .IgnoreNullValues(true);
        }
    }
}
