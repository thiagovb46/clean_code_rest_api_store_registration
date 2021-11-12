using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> Products;
        public ProductRepository()
        {
            Products = new List<Product>();
        }
        public void Register(Product product)
        {
            Products.Add(product);
        }
        public void Delete(Product product)
        {
            Products.Remove(product);
        }
    }
}
