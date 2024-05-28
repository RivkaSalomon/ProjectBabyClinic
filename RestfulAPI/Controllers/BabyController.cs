using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestfulAPI.Entities;
using RestfulAPI.Models;
using Solid.Core.DTOs;
using Solid.Core.Services;
using Solid.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private readonly IBabyService _babyService;
        private readonly IMapper _mapper;

        public BabyController(IBabyService babyService)
        {
            _babyService = babyService;
        }

        // GET: api/<BabyController>
        [HttpGet]
        public IEnumerable<Baby> Get()
        {
            return _babyService.GetBabies();
        }

        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public ActionResult<Baby> Get(int id)
        { var baby= _babyService.GetById(id);
            var babyDto = new BabyDto { Id = baby.Id, Age = baby.Age, Name = baby.Name };
            return Ok(babyDto);
        }

        // POST api/<BabyController>
        [HttpPost]
        public ActionResult Post([FromBody] BabyPostmodel baby)
        {
            var newBaby=new Baby { Age = baby.Age ,Name=baby.Name};
            return Ok(_babyService.AddBaby(newBaby));
        }



        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Baby baby)
        {
            return Ok(_babyService.UpdateBaby(id, baby));
        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var baby =_dataContext. lbaby.ToList().Find(x => x.Id == id);
          //_dataContext. lbaby.Remove(baby);
        //}
        public ActionResult Delete(int id)
        {
            var baby = _babyService.GetById(id);
            if (baby is null)
            {
                return NotFound();
            }
            _babyService.DeleteBaby(id);
            return NoContent();
        }
    }
}
