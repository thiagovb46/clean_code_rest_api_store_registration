using Application.CasosDeUso;
using Application.ViewModels;
using Domain.Models;
using Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Produtos
{
    public class CadastrarProduto: ICadastrarProduto
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public CadastrarProduto(IProdutoRepositorio produtoRepositorio) 
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public void Cadastrar(ProdutoViewModelInput produto) 
        {
            var novoproduto = new Produto(produto.Nome, produto.Preco,produto.produtoEstaAtivo);
            _produtoRepositorio.Cadastrar(novoproduto);
        }
    }
}
