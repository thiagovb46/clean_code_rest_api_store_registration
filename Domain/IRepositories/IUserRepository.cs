using Domain.Models;
using System.Collections.Generic;

namespace Domain.IRepositories
{
    public interface IUserRepository
    {
        public bool CreatesNewUser(User user);
        public void DeleteUser(int id);
        public List<User> ListAllUsers();
        public bool Login(User user);
    }
}
