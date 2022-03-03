using Application.ViewModels;
using Domain.IRepositories;
using Domain.Models;
using System.Collections.Generic;

namespace Application.UseCases.Users
{
    public class ListAllUsers : IListAllUsers
    {
        private readonly IUserRepository _userRepository;

        public ListAllUsers(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserViewModelOutput> ListAll()
        {
            List<UserViewModelOutput> usersViewModelOutput= new List<UserViewModelOutput>();
           
            foreach (User user in _userRepository.ListAllUsers())
           {
                usersViewModelOutput.Add(new UserViewModelOutput() {
                    Name = user.Name,
                    Id = user.Id
                });
           }
           return usersViewModelOutput;
        }
    }
}
