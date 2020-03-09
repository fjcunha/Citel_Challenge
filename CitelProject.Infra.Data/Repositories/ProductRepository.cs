using CitelProject.Domain.Entities;
using CitelProject.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CitelProject.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _db.Products.Where(p => p.CategoryID == categoryId).ToList();
        }
    }
}
