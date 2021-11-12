using Application.UseCases.Products;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        

        private readonly ILogger<ProductController> _logger;
        private readonly IProductRegister productRegister;


        public ProductController(ILogger<ProductController> logger, IProductRegister product)
        {
            _logger = logger;
            productRegister = product;

        }
        [HttpPost]
        public IActionResult Register([FromBody] ProductViewModel productViewModel) 
        {
            try
            {

                productRegister.Register(productViewModel);
                return Created("Criado com sucesso", true);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
