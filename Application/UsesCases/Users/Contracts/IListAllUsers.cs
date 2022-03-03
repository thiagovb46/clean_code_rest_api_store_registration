using Application.ViewModels;

using System.Collections.Generic;


namespace Application.UseCases.Users
{
    public interface IListAllUsers
    {
        public IEnumerable<UserViewModelOutput> ListAll();
    }
}
