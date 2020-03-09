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
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
            : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productRepository.GetProductsByCategoryId(categoryId);
        }
    }
}
