using System;
using System.Data.Entity;

namespace DAL.Context
{
    public class StudentsDBInitializer : DropCreateDatabaseIfModelChanges<StudentsContext>
    {
        protected override void Seed(StudentsContext context)
        {
            context.Courses.Add(new Models.Course { Name = "C# Starter", Hours = 20 });
            context.Courses.Add(new Models.Course { Name = "C# Essential", Hours = 20 });
            context.Courses.Add(new Models.Course { Name = "C# Proffesional", Hours = 20 });
            context.Students.Add(new Models.Student { FirstName = "Ivan", LastName = "Ivanov", Birthday = new DateTime(1982, 10, 26), Email = "ivan@gmail.com", Phone = "123456789" });
            context.SaveChanges();
        }


    }
}
