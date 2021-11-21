using Application.ViewModels;
using Domain.Models;
using Domain.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Usuarios
{
    public class ListarUsuarios : IListarUsuarios
    {
        private readonly IUsuarioRepositorio _usuarioRep;

        public ListarUsuarios(IUsuarioRepositorio usuarioRep)
        {
            _usuarioRep = usuarioRep;
        }
        public IEnumerable<UsuarioViewModelOutput> ListarTodos()
        {
            List<UsuarioViewModelOutput> usuariosViewModelOutput= new List<UsuarioViewModelOutput>();
           foreach (Usuario usuario in _usuarioRep.ListarTodos())
           {
                usuariosViewModelOutput.Add(new UsuarioViewModelOutput() {
                    Nome=usuario.Nome,
                    CodigoUsuario=usuario.Id
                });
           }
           return usuariosViewModelOutput;
        }
    }
}
