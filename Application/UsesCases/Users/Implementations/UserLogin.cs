using Application.Services;
using Application.Services.Cryptography;
using Application.ViewModels;
using Domain.IRepositories;
using Domain.Models;

namespace Application.UseCases.Users
{
    public class UserLogin : IUserLogin
    {
        private readonly IUserRepository _userRepository;
        private readonly ICriptography _criptographyService;
        private readonly ITokenService _tokenService;

        public UserLogin(IUserRepository userRepository, ICriptography criptographyService,ITokenService tokenService)
        {
            _userRepository = userRepository;
            _criptographyService = criptographyService;
            _tokenService = tokenService;

        }

        public string makeUserLogin(UserViewModelLogin userViewModelLogin)
        {
            if (_userRepository.Login
                (
                    new User()
                    {
                        Email = userViewModelLogin.Email,
                        Password = _criptographyService.Hash(userViewModelLogin.Password)
                    }
                )
              )

              {
                return _tokenService.GenerateToken(userViewModelLogin);
              }

            return "Login incorreto";
        }
    }
}
