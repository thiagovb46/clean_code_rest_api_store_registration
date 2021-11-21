using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Usuarios
{
    public interface IListarUsuarios
    {
        public IEnumerable<UsuarioViewModelOutput> ListarTodos();
    }
}
