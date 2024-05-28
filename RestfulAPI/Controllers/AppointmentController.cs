using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Entities;
using RestfulAPI.Models;
using Solid.Core.DTOs;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;
      public AppointmentController(IAppointmentService appointmentService,IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        // GET: api/<AppointmentController>
        [HttpGet] 
        public ActionResult Get()
        {
            var list = _appointmentService.GetAppointments();
            //List<Appointment> list = new List<Appointment>();
            //var listDto= _mapper.Map<IEnumerable<AppointmentDto>>(list);
            return Ok(_mapper.Map<IEnumerable<AppointmentDto>>(list));
        }

        //GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Appointment> GetById(int id)
        {
            var appointmentd = _appointmentService.GetById(id);
            var appointmentdto = _mapper.Map<AppointmentDto>(appointmentd);
            return Ok(appointmentdto);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] AppointmentPostModel app)
        {
            var appointment = new Appointment {Date= app.Date,Subject= app.Subject,NurseId=app.NurseId,BabyId=app.BabyId};
            var newAppointment=_appointmentService.AddAppointment(appointment);
            return Ok(newAppointment);
        }
        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment app)
        {
            return Ok(_appointmentService.UpdateAppointment(id, app));

        }
        
        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var appo = _appointmentService.GetById(id);
            if (appo is null)
            {
                return NotFound();
            }
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
           
        }
    }

