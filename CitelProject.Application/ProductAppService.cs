using CitelProject.Application.Interface;
using CitelProject.Domain.Entities;
using CitelProject.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CitelProject.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
            : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productService.GetProductsByCategoryId(categoryId);
        }
    }
}
