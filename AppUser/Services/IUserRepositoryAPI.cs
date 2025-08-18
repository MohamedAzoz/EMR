using UerApp.Models;

namespace UerApp.Services
{
    public interface IUserRepositoryAPI
    {
        void AddUser(UserAPI user);
        UserAPI GetById(int id);
        void DeleteById(int id);


    }
}
