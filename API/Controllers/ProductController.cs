using Application.useCases.Products;
using Application.UseCases.Products;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ICreateNewProduct _createProductUseCase;
        private readonly IDeleteProduct _deleteProductUseCase;
        private readonly IListAllProducts _getAllProductsUseCase;

        public ProductController(ICreateNewProduct createNewProductUseCase,IDeleteProduct deleteProductUseCase,IListAllProducts listAllProductsUseCase)
        {
            _createProductUseCase = createNewProductUseCase;
            _deleteProductUseCase = deleteProductUseCase;
            _getAllProductsUseCase = listAllProductsUseCase;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] ProductViewModelInput productViewModelInput)
        {
            try
            {
                _createProductUseCase.CreateProduct(productViewModelInput);
                return Created("Criado com sucesso", productViewModelInput);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            try
            {
                _deleteProductUseCase.Delete(id);
                return Ok("Deletado");
            }

            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_getAllProductsUseCase.ListAll());
        }
    }
}
