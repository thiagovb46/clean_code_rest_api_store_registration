using Application.ViewModels;
using Domain.IRepositories;
using Domain.Models;

namespace Application.UseCases.Products
{
    public class CreateNewProduct: ICreateNewProduct
    {
        private readonly IProductRepository _productRepository;
        public CreateNewProduct(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public void CreateProduct(ProductViewModelInput product)
        {
            var newProduct = new Product(product.Name, product.Price, product.IsActive);
            _productRepository.CreatesNewProduct(newProduct);
        }
    }
}
