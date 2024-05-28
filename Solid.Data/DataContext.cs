using Microsoft.EntityFrameworkCore;
using RestfulAPI.Entities;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Appointment> li { get; set; }

        public DbSet<Baby> lbaby { get; set; }
       // public int Count = 0;
        public DbSet<Nurse> ln { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Rivkas_db");
        }
    }
}