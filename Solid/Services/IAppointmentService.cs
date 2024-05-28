using RestfulAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAppointments();

        Appointment GetById(int id);
        Appointment AddAppointment(Appointment id);
        Appointment UpdateAppointment(int id, Appointment appointment);
        void DeleteAppointment(int id);
    }
}
