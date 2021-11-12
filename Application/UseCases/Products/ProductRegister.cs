using Application.UseCases.Products;
using Application.ViewModels;
using Domain.DomainsObjects.ValueObjects;
using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products
{
    public class ProductRegister: IProductRegister
    {
        private readonly IProductRepository _productRepository;
        public ProductRegister(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public void Register(ProductViewModel product) 
        {
            
            var newproduct = new Product(product.Ammount,product.Description,product.Price,new Dimensions (product.HeightInCentimeters,product.WidthInCentimeters,product.DepthInCentimeters));
            _productRepository.Register(newproduct);
        }
    }
}
