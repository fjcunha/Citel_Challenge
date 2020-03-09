using CitelProject.Application.Interface;
using CitelProject.Domain.Entities;
using CitelProject.Domain.Interfaces.Services;

namespace CitelProject.Application
{
    public class CategoryAppService: AppServiceBase<Category>, ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService) 
            : base(categoryService)
        {
            _categoryService = categoryService;
        }

    }
}
