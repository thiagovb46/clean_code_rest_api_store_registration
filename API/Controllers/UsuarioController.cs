using Application.CasosDeUso.Usuarios;
using Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ICadastrarUsuario usuarioCad;

        public readonly IDeletarUsuario _usuarioDelete;
        private readonly IListarUsuarios _usuarioListar;

        public UsuarioController(ICadastrarUsuario usuario,IDeletarUsuario usuarioDelete,IListarUsuarios usuarioListar)
        {
            usuarioCad = usuario;
            _usuarioDelete = usuarioDelete;
            _usuarioListar = usuarioListar;
        }

        [HttpPost]
        public ActionResult Create(UsuarioViewModelInput novousuario)
        {
            try
            {
                usuarioCad.Cadastrar(novousuario);
                return Created("Sucesso", novousuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _usuarioDelete.Deletar(id);
                return Ok("Usuário apagado");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpGet]
        public ActionResult Listar()
        {
            try
            {
                return Ok(_usuarioListar.ListarTodos());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}

