using System.Data.Entity;
namespace LR1ASP.Models { 
    public class GradeDbInitializer : DropCreateDatabaseAlways<StudentMarksContext> { 
        protected override void Seed(StudentMarksContext db) { 
            db.Students.Add(new Student { 
                Name = "Владислав", 
                Surname = "Собко", 
                Group = "ІПЗс-19-1",
                Course = 2,
               
            });
            db.Students.Add(new Student {
                Name = "Джонні",
                Surname = "Депп",
                Group = "ІПЗ-17-1",
                Course = 4,
               
            }); 
            db.Students.Add(new Student {
                Name = "Бред",
                Surname = "Пітт",
                Group = "ІПЗс-18-1",
                Course = 3,
               
            }); 
            base.Seed(db); 
        } 
    } 
}