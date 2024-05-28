using RestfulAPI.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public Appointment AddAppointment(Appointment id)
        {

            return _appointmentRepository.AddAppointment(id);
        }

        public void DeleteAppointment(int id)
        {
            _appointmentRepository.DeleteAppointment(id);   
        }
      
        public IEnumerable<Appointment> GetAppointments()
        {
            return _appointmentRepository.GetAll();
        }


        public Appointment GetById(int id)
        {
            return _appointmentRepository.GetById(id);
        }

        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            return _appointmentRepository.UpdateAppointment(id, appointment);
        }
    }
}
