using Application.Services.Cryptography;
using Application.ViewModels;
using Domain.IRepositories;
using Domain.Models;

namespace Application.UseCases.Users
{
    public class CreateNewUser : ICreateNewUser
    {
        private readonly ICriptography _criptographyService;
        private readonly IUserRepository _userRepository;

        public CreateNewUser(IUserRepository userRepository,ICriptography criptographyService)
        {
            _criptographyService = criptographyService;
            _userRepository = userRepository;

        }
        public bool CreateUser(UserViewModelInput userViewModelInput)
        {
            User newUser = new User(userViewModelInput.Name, userViewModelInput.Email,_criptographyService.Hash(userViewModelInput.Password));
            return _userRepository.CreatesNewUser(newUser);
        }
    }
}
