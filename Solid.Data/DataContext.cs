using Microsoft.EntityFrameworkCore;
using RestfulAPI.Entities;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Appointment> appointments { get; set; }

        public DbSet<Baby> babis { get; set; }
       // public int Count = 0;
        public DbSet<Nurse> nurses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Rivkas_db");
        }
    }
}