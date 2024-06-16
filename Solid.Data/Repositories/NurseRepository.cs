using RestfulAPI.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class NurseRepository: INurseRepository
    {
        private readonly DataContext _context;
        public NurseRepository(DataContext data)
        {
            _context = data;
        }
        public Nurse AddNurse(Nurse nurse)
        {
            _context.nurses.Add(nurse);
            _context.SaveChanges();
            return nurse;
        }

        public void DeleteNurse(int id)
        {
            var nurse = GetById(id);
            _context.nurses.Remove(nurse);
            _context.SaveChanges();
           // _context.ln.Remove(_context.ln.ToList().Find(u => u.Id == id));
        }

        public Nurse GetById(int id)
        {
            return _context.nurses.ToList().Find(u => u.Id == id);

        }

        public IEnumerable<Nurse> GetAll()
        {
            return _context.nurses.ToList();
        }

        public Nurse UpdateNurse(int id, Nurse nurse)
        {
            var updateUser = _context.nurses.ToList().Find(u => u.Id == id);
            updateUser.Price = nurse.Price;
            updateUser.Name = nurse.Name;
            _context.SaveChanges();
            return updateUser;
        }
      

        
    }
}
