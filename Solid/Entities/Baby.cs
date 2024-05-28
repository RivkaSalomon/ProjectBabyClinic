using System.ComponentModel.DataAnnotations;

namespace RestfulAPI.Entities
{
    public class Baby
    {
    
      public  int Id { get; set; }    
      public string Name { get; set; }   
      public int Age { get; set; }

      public List<Appointment> Appointments { get; set; }
    }
}
