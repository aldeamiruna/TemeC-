using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tema3_ProductApp.Repositories;

namespace Tema3_ProductApp.Models
{
    public class ProductRepository : IProductRepository
    {
        readonly IEnumerable<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "IceCream",
                Description = "is so yummi"

            },
            new Product

            {
                Id = 2,
                Name = "French fries",
                Description = " are the best"

            },
            new Product
            {
                Id = 3,
                Name = "Salad",
                Description = " is healthy"

            }

        };

        public IEnumerable<Product> Products => _products;


        public Product GetById(int id)
        {
            return _products.SingleOrDefault(x => x.Id == id);
        }
    }
}

