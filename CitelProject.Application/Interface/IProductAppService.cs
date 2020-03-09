using CitelProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}
