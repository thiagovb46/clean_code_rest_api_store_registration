using Application.ViewModels;

namespace Application.UseCases.Products
{
    public interface ICreateNewProduct
    {
        public void CreateProduct(ProductViewModelInput product);
    }
}
