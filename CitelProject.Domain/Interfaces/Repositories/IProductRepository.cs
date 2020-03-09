using CitelProject.Domain.Entities;
using System.Collections.Generic;

namespace CitelProject.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);

    }
}
