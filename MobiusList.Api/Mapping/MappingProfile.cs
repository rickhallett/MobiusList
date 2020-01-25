using AutoMapper;
using MobiusList.Api.Resources;
using MobiusList.Core.Models;

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
        }
    }
}