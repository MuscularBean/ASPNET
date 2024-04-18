using System;
using System.Collections.Generic;
using Testing.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Testing
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

    }
}
