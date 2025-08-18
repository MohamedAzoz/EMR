using EMR.Uer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Uer_App.Services
{
    public class UserRepository : IUserRepository
    {
        List<User> users = new List<User>();
        public UserRepository() 
        {
            users = new List<User>()
            {
                new User{Id=1,Name="Ali",Email="Ali@gmail.com",Password="123456"},
                new User{Id=2,Name="Ahmed",Email="Ahmed@gmail.com",Password="123456"},
                new User{Id=3,Name="Mahmoud",Email="Mahmoud@gmail.com",Password="123456"},
                new User{Id=4,Name="Mohamed",Email="Mohamed@gmail.com",Password="123456"},
                new User{Id=5,Name="Omer",Email="Omer@gmail.com",Password="123456"}
            };
        }
        public void Add(User user)
        {
            users.Add(user);
        }

        public void DeleteById(int id)
        {
            var user = GetById(id);
            users.Remove(user!);
        }

        public User GetById(int id)
        {
            try
            {
                var user = users.FirstOrDefault(x => x.Id == id);
                return user!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
//