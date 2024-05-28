using RestfulAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface INurseService
    {
        IEnumerable<Nurse> GetAll();
        Nurse GetById(int id);
        Nurse AddNurse(Nurse Nurse);
        Nurse UpdateNurse(int id, Nurse Nurse);
        void DeleteNurse(int id);
    }
}
