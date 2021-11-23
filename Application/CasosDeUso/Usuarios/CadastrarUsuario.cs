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
    public class CadastrarUsuario : ICadastrarUsuario
    {
        private readonly ICriptografia _criptografia;
        private readonly IUsuarioRepositorio _UsuarioRep;

        public CadastrarUsuario(IUsuarioRepositorio UsuarioRep,ICriptografia criptografia)
        {
            _criptografia = criptografia;
            _UsuarioRep = UsuarioRep;

        }
        public void Cadastrar(UsuarioViewModelInput novousuarioViewModel)
        {
            Usuario novoUsuario = new Usuario(novousuarioViewModel.Nome,novousuarioViewModel.Email,_criptografia.Hash(novousuarioViewModel.Senha));
            _UsuarioRep.Cadastrar(novoUsuario);
        }
    }
}
