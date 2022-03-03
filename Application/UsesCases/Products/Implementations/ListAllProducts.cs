using Application.ViewModels;
using Domain.IRepositories;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application.useCases.Products
{
    public class ListAllProducts : IListAllProducts
    {
        private readonly IProductRepository _productRepository;

        public ListAllProducts(IProductRepository productRepository )
        {
            _productRepository = productRepository;
        }
        public IEnumerable<ProductViewModelOutput> ListAll()
        {
            List<ProductViewModelOutput> productsViewModelList = new List<ProductViewModelOutput>();
            List<Product> productsList = _productRepository.ListAllProducts();
            string statusProd;

            foreach(Product product in productsList)
            {
                if (product.isActive)
                    statusProd = "Ativo";
                else
                    statusProd = "Inativo";

                productsViewModelList.Add(new ProductViewModelOutput() 
                {
                    Name = product.Name,
                    Price = product.Price,
                    Status = statusProd,
                    ProductId = product.Id
                });
            }
            return productsViewModelList.AsEnumerable();
        }
    }
}
