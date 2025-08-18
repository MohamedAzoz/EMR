using UerApp.Models;

namespace UerApp.Services
{
    public class UserRepositoryAPI : IUserRepositoryAPI
    {
        private readonly AppDbContext context;

        public UserRepositoryAPI(AppDbContext context) 
        {
            this.context = context;
        }
        public void AddUser(UserAPI user)
        {
            context.Add(user);
        }

        public void DeleteById(int id)
        {
            var user = GetById(id);
            context.Remove(user!);
        }

        public UserAPI GetById(int id)
        {
            try
            {
                var user = context.Users.FirstOrDefault(x => x.Id == id);
                return user!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
