using Domain.IRepositories;

namespace Application.UseCases.Products
{
    public class DeleteProduct : IDeleteProduct
    {
        private readonly IProductRepository _productRepository;

        public DeleteProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public void Delete(int id)
        {
            _productRepository.DeleteProduct(id);
            
        }
    }
}
