namespace DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class StudentsContext : DbContext
    {
        static StudentsContext()
        {
            Database.SetInitializer(new StudentsDBInitializer());
        }
        
        public StudentsContext()
            : base("name=StudentsDB")
        {
        }

        

         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Trainer> Trainers { get; set; }
         public virtual DbSet<Auditory> Auditories { get; set; }
         public virtual DbSet<Schedule> Schedules { get; set; }
         public virtual DbSet<Course> Courses { get; set; }

    }
       
}