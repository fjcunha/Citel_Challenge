using AutoMapper;
using CitelProject.Domain.Entities;
using CitelProject.WebApi.ViewModels;

namespace CitelProject.WebApi.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}