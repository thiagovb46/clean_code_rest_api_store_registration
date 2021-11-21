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
    public class UsuarioRepositorio : IUsuarioRepositorio

    {
        private readonly LojaContext _contexto;

        public UsuarioRepositorio(LojaContext contexto)
        {
            _contexto = contexto;

        }
        public void Cadastrar(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            _contexto.Remove(_contexto.Usuarios.FirstOrDefault(u => u.Id==id));
            _contexto.SaveChanges();
;        }

        public List<Usuario> ListarTodos()
        {
            return _contexto.Usuarios.ToList();
        }
    }
}
