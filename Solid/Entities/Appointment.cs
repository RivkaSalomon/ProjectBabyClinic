using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestfulAPI.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public Baby Baby { get; set; }
        public int BabyId { get; set; }

      //  public Nurse Nurse { get; set; }
        public int NurseId { get; set; }


        //Appointment(DateOnly d,string s,int id)
        //{
        //    Date = d;
        //    Subject = s;
        //    Id = id;
        //}
        //Appointment()
        //{ }

    }
}
