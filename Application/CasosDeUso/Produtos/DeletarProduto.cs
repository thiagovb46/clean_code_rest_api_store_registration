using Application.ViewModels;
using Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Produtos
{
    public class DeletarProduto : IDeletarProduto
    {
        private readonly IProdutoRepositorio _prodRep;

        public DeletarProduto(IProdutoRepositorio produtoRep)
        {
            _prodRep = produtoRep;

        }
        public void Deletar(int id)
        {
            _prodRep.Deletar(id);
            
        }
    }
}
