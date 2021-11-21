using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositorios
{
    public interface IUsuarioRepositorio
    {
        public void Cadastrar(Usuario usuario);
        public void Deletar(int id);
        public List<Usuario> ListarTodos();
    }
}
