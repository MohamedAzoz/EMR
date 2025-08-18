using EMR.Uer_App.Models;
using EMR.Uer_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR
{
    public class AppointmentSchaduler : IAppointmentSchaduler
    {
        private readonly IUserRepository repository;

        public AppointmentSchaduler(IUserRepository repository)
        {
            this.repository = repository;
        }
        public User Schaduler(int id)
        {
             var user=repository.GetById(id);
            if (user == null) 
                throw new AggregateException("Not Found");
            else
                return user;
        }
    }
}
