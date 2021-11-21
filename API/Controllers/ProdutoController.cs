using Application.CasosDeUso.Produtos;
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
    public class ProdutoController : ControllerBase
    {
        private readonly ICadastrarProduto produtoCad;
        private readonly IDeletarProduto produtoDel;
        private readonly IListarProdutos produtosGet;

        public ProdutoController(ICadastrarProduto produto,IDeletarProduto _produto,IListarProdutos produtos)
        {
            produtoCad = produto;
            produtoDel = _produto;
            produtosGet = produtos;
        }
        [HttpPost]
        public IActionResult Cadastrar([FromBody] ProdutoViewModelInput produtoViewModel)
        {
            try
            {
                produtoCad.Cadastrar(produtoViewModel);
                return Created("Criado com sucesso", produtoCad);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            try
            {
                produtoDel.Deletar(id);
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
            return Ok(produtosGet.ListarTodos());
        }
    }
}
