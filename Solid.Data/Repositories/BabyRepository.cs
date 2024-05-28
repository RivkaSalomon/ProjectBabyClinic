using RestfulAPI.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class BabyRepository: IBabyRepository
    {
        private readonly DataContext _context;
        public BabyRepository(DataContext data)
        {
            _context = data;
        }
        public Baby AddBaby(Baby baby)
        {
            _context.lbaby.Add(baby);
            _context.SaveChanges();
            return baby;
        }

        //public void DeleteBaby(int id)
        //{
        //    _context.lbaby.Remove(_context.lbaby.ToList().Find(u => u.Id == id));
        //}
        public void DeleteBaby(int id)
        {
            var baby = GetById(id);
            _context.lbaby.Remove(baby);
            _context.SaveChanges();
        }
        public Baby GetById(int id)
        {
            return _context.lbaby.ToList().Find(u => u.Id == id);
        }

        public IEnumerable<Baby> GetBabies()
        {
            return _context.lbaby.ToList();
        }
       
        public Baby UpdateBaby(int id, Baby baby)
        {
            var updateUser = _context.lbaby.ToList().Find(u => u.Id == id);

            updateUser.Age = baby.Age;
            updateUser.Name = baby.Name;

            _context.SaveChanges();
            return updateUser;
        }
        //public Baby DeleteBaby()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
