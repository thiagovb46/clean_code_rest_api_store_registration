using Domain.Models;
using Domain.IRepositories;
using Infra.Context;
using System.Collections.Generic;
using System.Linq;
namespace Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public void CreatesNewProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product tobeDeleted = _context.Products.FirstOrDefault(p => p.Id == id);
            _context.Products.Remove(tobeDeleted);
            _context.SaveChanges();
        }

        public List<Product> ListAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
