using AutoMapper;
using CitelProject.Domain.Entities;
using CitelProject.WebApi.ViewModels;

namespace CitelProject.WebApi.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}