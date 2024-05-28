using AutoMapper;
using RestfulAPI.Entities;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment,AppointmentDto>().ReverseMap();
            CreateMap<Baby, BabyDto>().ReverseMap();
            CreateMap<Nurse, NurseDto>().ReverseMap();

        }
    }
}
