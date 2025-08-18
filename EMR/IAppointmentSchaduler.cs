using EMR.Uer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR
{
    public interface IAppointmentSchaduler
    {
        User Schaduler(int id);
    }
}
