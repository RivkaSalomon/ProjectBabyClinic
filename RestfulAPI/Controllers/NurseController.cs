using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Entities;
using RestfulAPI.Models;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService _nurseService;
        private readonly IMapper _mapper;

        public NurseController (INurseService nurseService)
        {
            _nurseService = nurseService;
        }
        // GET: api/<NurseController>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return _nurseService.GetAll();
        }

        // GET api/<NurseController>/5
        [HttpGet("{id}")]
        public ActionResult<Nurse> Get(int id)
        {
            var nurse= _nurseService.GetById(id);
            var nurseDto = new Nurse { Name = nurse.Name, CountHours = nurse.CountHours, Price = nurse.Price, Id = nurse.Id };
            return Ok(nurseDto);
        }

        // POST api/<NurseController>
        [HttpPost]
        //public void Post([FromBody] Nurse nurse)
        //{
        //   _dataContext. ln.Add(new Nurse {Name=nurse.Name,CountHours=nurse.CountHours,Price=nurse.Price, Id= _dataContext .Count});

        //}
        public ActionResult Post([FromBody] NursePostModel nurse)
        {
            var newnurse=new Nurse { Name = nurse.Name,Price=nurse.Price,CountHours=nurse.CountHours };
            return Ok(_nurseService.AddNurse(newnurse));
        }
        // PUT api/<NurseController>/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] Nurse nurse)
        //{
        //    var nur =_dataContext. ln.ToList().Find(x => x.Id == id);
        //    nur.Name = nurse.Name;
        //    nur.CountHours = nurse.CountHours;
        //    nur.Price = nurse.Price;
        //}
        public ActionResult Put(int id, [FromBody] Nurse nurse)
        {
            return Ok(_nurseService.UpdateNurse(id, nurse));
        }
        // DELETE api/<NurseController>/5
        [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var nurse =_dataContext. ln.ToList().Find(x => x.Id == id);
        //    _dataContext.  ln.Remove(nurse);
        //}
        public ActionResult Delete(int id)
        {
            var nurse = _nurseService.GetById(id);
            if (nurse is null)
            {
                return NotFound();
            }
            _nurseService.DeleteNurse(id);
            return NoContent();
        }
    }
}
