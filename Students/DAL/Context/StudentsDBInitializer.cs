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
            context.SaveChanges();
        }

        
    }
}
