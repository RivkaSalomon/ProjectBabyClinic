using RestfulAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class AppointmentDto
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        
        public int Id { get; set; }
        [ForeignKey("babyId")]
        public BabyDto BabyId { get; set; }
        [ForeignKey("nurseId")]

        public NurseDto NurseId { get; set; }


    }
}
