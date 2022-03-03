using Application.ViewModels;

namespace Application.UseCases.Users
{
    public interface ICreateNewUser
    {
        public bool CreateUser(UserViewModelInput newUser);
    }
}
