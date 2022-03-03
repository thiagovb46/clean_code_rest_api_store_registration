using Domain.IRepositories;

namespace Application.UseCases.Users
{
    public class DeleteUser : IDeleteUser
    {
        private readonly IUserRepository _userRepository;
        public DeleteUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Delete(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
