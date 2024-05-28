using RestfulAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IBabyRepository
    {
        IEnumerable<Baby> GetBabies();
        Baby GetById(int id);
        Baby AddBaby(Baby baby);
        Baby UpdateBaby(int id,Baby baby); 
        void DeleteBaby(int id);
       // Baby DeleteBaby();
    }
}
