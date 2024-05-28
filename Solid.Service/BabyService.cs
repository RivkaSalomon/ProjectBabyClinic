using RestfulAPI.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;

namespace Solid.Service
{
    public class BabyService : IBabyService
    {
        private readonly IBabyRepository _babyRepository;
        public BabyService(IBabyRepository babyRepository)
        {
            _babyRepository = babyRepository;
        }
        public Baby AddBaby(Baby baby)
        {
           return _babyRepository.AddBaby(baby);
        }

        //public Baby DeleteBaby(int id)
        //{
        //    return _babyRepository.DeleteBaby();
        //}
        public void DeleteBaby(int id)
        {
            _babyRepository.DeleteBaby(id);
        }
        public IEnumerable<Baby> GetBabies()
        {
            return _babyRepository.GetBabies();
        }

        public Baby GetById(int id)
        {
            return _babyRepository.GetById(id);
        }

        public Baby UpdateBaby(int id, Baby baby)
        {
            return _babyRepository.UpdateBaby(id, baby);
        }

    }
}