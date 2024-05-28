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
    public class NurseService : INurseService
    {
        private readonly INurseRepository _nurseRepository;
        public NurseService(INurseRepository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }
        public Nurse AddNurse(Nurse Nurse)
        {
            return _nurseRepository.AddNurse(Nurse);
        }

        public void DeleteNurse(int id)
        {
            _nurseRepository.DeleteNurse(id);
        }

        public IEnumerable<Nurse> GetAll()
        {
            return _nurseRepository.GetAll();
        }

        public Nurse GetById(int id)
        {
            return _nurseRepository.GetById(id);
        }

        public Nurse UpdateNurse(int id, Nurse Nurse)
        {
           return _nurseRepository.UpdateNurse(id, Nurse);
        }
    }
}
