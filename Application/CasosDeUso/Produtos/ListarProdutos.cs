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
    public class ListarProdutos : IListarProdutos
    {
        private readonly IProdutoRepositorio _prodRed;

        public ListarProdutos(IProdutoRepositorio prodRep )
        {
            _prodRed = prodRep;

        }
        public IEnumerable<ProdutoViewModelOutput> ListarTodos()
        {
            List<ProdutoViewModelOutput> ProdutosVM = new List<ProdutoViewModelOutput>();
            List<Produto> ListaProdutos = _prodRed.ListarTodos();
            string statusProd;
            foreach(Produto produto in ListaProdutos)
            {
                if (produto.EstaAtivo)
                    statusProd = "Ativo";
                else
                    statusProd = "Inativo";
                ProdutosVM.Add(new ProdutoViewModelOutput() 
                {
                    Nome=produto.Nome,
                    Preco=produto.Preco,
                    Status=statusProd,
                    CodigoDoProduto=produto.Id
                });
            }
            return ProdutosVM.AsEnumerable();
        }
    }
}
