using EMR.Uer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Uer_App.Services
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
        void DeleteById(int id);


    }
}
