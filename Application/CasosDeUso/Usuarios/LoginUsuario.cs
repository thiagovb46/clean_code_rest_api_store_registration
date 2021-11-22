using Application.Servicos;
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
    public class LoginUsuario : ILoginUsuario
    {
        private readonly IUsuarioRepositorio _usuarioRep;
        private readonly ICriptografia _cripto;
        private readonly ITokenService _tokenservice;

        public LoginUsuario(IUsuarioRepositorio usuarioRep,ICriptografia cripto,ITokenService tokenservice)
        {
            _usuarioRep = usuarioRep;
            _cripto = cripto;
            _tokenservice = tokenservice;

        }
        public string validaLogin(UsuarioViewModelLogin usuarioviewmodellogin)
        {
            if (_usuarioRep.Login
                (new Usuario()
                {
                    Email = usuarioviewmodellogin.Email,
                    senha =usuarioviewmodellogin.Senha
                }
                )
                )
            {
                return _tokenservice.GenerateToken(usuarioviewmodellogin);

            }
            return "Login incorreto";
        }
    }
}
