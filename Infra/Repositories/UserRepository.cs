using Domain.Models;
using Domain.IRepositories;
using Infra.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorios
{
    public class UserRepository : IUserRepository

    {
        private readonly StoreContext _context;

        public UserRepository(StoreContext context)
        {
            _context = context;

        }
        public bool CreatesNewUser(User user)
        {
            if (_context.Users.FirstOrDefault(u => u.Email == user.Email) == null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteUser(int id)
        {
            _context.Remove(_context.Users.FirstOrDefault(u => u.Id==id));
            _context.SaveChanges();
;        }

        public List<User> ListAllUsers()
        {
            return _context.Users.ToList();
        }
        public bool Login(User user)
        {
            if (_context.Users.First(u => (u.Email == user.Email && u.Password == user.Password)) == null)
                return false;
            return true;
        }
    }
}
