using UerApp.Models;
using UerApp.Services;

namespace UerApp
{
    public class AppointmentSchadulerAPI : IAppointmentSchadulerAPI
    {
        private readonly IUserRepositoryAPI repository;

        public AppointmentSchadulerAPI(IUserRepositoryAPI repository)
        {
            this.repository = repository;
        }
        public UserAPI Schaduler(int id)
        {
             var user=repository.GetById(id);
            if (user == null) 
                throw new AggregateException("Not Found");
            else
                return user;
        }
    }
}
