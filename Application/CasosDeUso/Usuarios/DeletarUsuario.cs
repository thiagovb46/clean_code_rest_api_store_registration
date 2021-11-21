using Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Usuarios
{
    public class DeletarUsuario : IDeletarUsuario
    {
        private readonly IUsuarioRepositorio _usuarioRep;
        public DeletarUsuario(IUsuarioRepositorio usuarioRep)
        {
            _usuarioRep = usuarioRep;
        }
        public void Deletar(int id)
        {
            _usuarioRep.Deletar(id);
        }
    }
}
