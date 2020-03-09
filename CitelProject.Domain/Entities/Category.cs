using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitelProject.Domain.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
