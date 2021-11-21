using Domain.Models;
using Domain.Repositorios;
using Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly LojaContext _context;

        public ProdutoRepositorio(LojaContext context)
        {
            _context = context;
        }
        public void Cadastrar(Produto produto)
        {
            _context.Products.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Produto removido = _context.Products.FirstOrDefault(p => p.Id == id);
            _context.Products.Remove(removido);
            _context.SaveChanges();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Products.ToList();
        }
    }
}
