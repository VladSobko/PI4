using System.Data.Entity;

namespace LR1ASP.Models
{
    public class StudentMarksContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        //public DbSet<Mark> Marks { get; set; }
    }
}