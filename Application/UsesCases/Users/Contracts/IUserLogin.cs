using Application.ViewModels;

namespace Application.UseCases.Users
{
    public interface IUserLogin
    {
        public string makeUserLogin(UserViewModelLogin userViewModelLogin);
    }
}
