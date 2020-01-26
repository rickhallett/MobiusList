using AutoMapper;
using MobiusList.Api.Contracts.Request;
using MobiusList.Api.Resources;
using MobiusList.Data.Models;

namespace MobiusList.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Product, ProductResource>();
            CreateMap<Category, CategoryResource>();

            // Resource to Domain
            CreateMap<ProductResource, Product>();
            CreateMap<CategoryResource, Category>();
            
            // Request to Domain
            // TODO: find out how to use AutoMapper when TSource cannot be found by convention
            CreateMap<CreateProductRequest, Product>();
        }
    }
}