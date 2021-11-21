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

        public UsuarioController(ICadastrarUsuario usuario)
        {
            usuarioCad = usuario;
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

    }
}

