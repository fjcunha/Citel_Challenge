using CitelProject.Domain.Entities;
using CitelProject.Domain.Interfaces.Repositories;
using CitelProject.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Domain.Services
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
            : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
