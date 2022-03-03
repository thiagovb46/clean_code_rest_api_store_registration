using Domain.Models;
using System.Collections.Generic;

namespace Domain.IRepositories
{
    public interface IProductRepository
    {
        public void CreatesNewProduct(Product product);
        public void DeleteProduct(int id);
        public List<Product> ListAllProducts();

    }
}
