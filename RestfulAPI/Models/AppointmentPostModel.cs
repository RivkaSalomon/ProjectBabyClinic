using RestfulAPI.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestfulAPI.Models
{
    public class AppointmentPostModel
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        // public int Id { get; set; }
      
        public Baby BabyId { get; set; }
    

        public Nurse NurseId { get; set; }
    }
}
