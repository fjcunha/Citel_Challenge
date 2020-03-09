using CitelProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Domain.Interfaces.Services
{
    public interface IProductService: IServiceBase<Product>
    {
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}
