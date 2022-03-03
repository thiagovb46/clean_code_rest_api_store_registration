using Application.ViewModels;
using System.Collections.Generic;

namespace Application.useCases.Products
{
    public interface IListAllProducts
    {
        public IEnumerable<ProductViewModelOutput>ListAll();
    }
}
