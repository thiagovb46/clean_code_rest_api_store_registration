using Application.UseCases.Users;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICreateNewUser _createNewUserUseCase;
        public readonly IDeleteUser _deleteUserUseCase;
        private readonly IListAllUsers _listAllUsersUseCase;
        private readonly IUserLogin _userLoginUseCase;

        public UserController(ICreateNewUser createNewUserUseCase, IDeleteUser deleteUserUseCase, IListAllUsers listAllUsersUseCase, IUserLogin userLoginUseCase)
        {
            _createNewUserUseCase = createNewUserUseCase;
            _deleteUserUseCase = deleteUserUseCase;
            _listAllUsersUseCase = listAllUsersUseCase;
            _userLoginUseCase = userLoginUseCase;
        }

        [HttpPost]
        public ActionResult Create(UserViewModelInput newUser)
        {
            try
            {
                
                if(_createNewUserUseCase.CreateUser(newUser))
                return Created("Sucesso", newUser);
                return BadRequest("O Email cadastrado já existe na base de dados.");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        
        [HttpPost]
        [Route("/login")]
        public ActionResult Login(UserViewModelLogin userViewModelLogin )
        {
            try
            {
                if(_userLoginUseCase.makeUserLogin(userViewModelLogin) == "Login incorreto")
                return NotFound();
                return Ok(_userLoginUseCase.makeUserLogin(userViewModelLogin));
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
                _deleteUserUseCase.Delete(id);
                return Ok("Usuário apagado");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpGet]
        public ActionResult ListAll()
        {
            try
            {
                return Ok(_listAllUsersUseCase.ListAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}

