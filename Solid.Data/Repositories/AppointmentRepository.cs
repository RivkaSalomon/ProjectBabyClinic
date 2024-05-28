using Microsoft.EntityFrameworkCore;
using RestfulAPI.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class AppointmentRepository :IAppointmentRepository
    {
        private readonly DataContext _context;
        public AppointmentRepository(DataContext data)
        {
            _context = data;
        }

        public Appointment AddAppointment(Appointment appointment)
        {
            _context.li.Add(appointment);
            _context.SaveChanges();

            return appointment;
        }

        public void DeleteAppointment(int id)
        {
            var appointmentp = GetById(id);
            _context.li.Remove(appointmentp);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.li.Include(a=>a.BabyId);

        }

        public Appointment GetById(int id)
        {
            return _context.li.Include(a => a.BabyId).First(a => a.Id == id);
            //return _context.li.Include(a => a.NurseId).First(a => a.Id == id)
        }

        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            var updateUser = _context.li.ToList().Find(u => u.Id == id);
            updateUser.Subject = appointment.Subject;
            _context.SaveChanges();
            return updateUser;
        }
    }
    //public void DeleteAppointment(int id)
    //{
    //    var appointmentp = GetById(id);
    //    _context.li.Remove(appointmentp);
    //    _context.SaveChanges();
    //    // _context.li.Remove(_context.li.ToList().Find(u => u.Id == id));
    //}

    //public Appointment GetById(int id)
    //{

    //    return _context.li.ToList().Find(u => u.Id == id);
    //}

    //public IEnumerable<Appointment> GetAll()
    //{
    //    return _context.li.ToList();
    //}

   
      
    
    //public Appointment UpdateAppointment(int id, Appointment appointment)
    //{
    //    var updateUser = _context.li.ToList().Find(u => u.Id == id);
    //    updateUser.Subject = appointment.Subject;
    //    _context.SaveChanges();
    //    return updateUser;
    //}
    //public Appointment AddAppointment(Appointment appointment)
    //{
    //    _context.li.Add(appointment);
    //    _context.SaveChanges();

    //    return appointment;
    //}



}
    


