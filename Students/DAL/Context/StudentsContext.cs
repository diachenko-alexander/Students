namespace DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class StudentsContext : DbContext
    {
        // Your context has been configured to use a 'StudentsDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Context.StudentsDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentsDB' 
        // connection string in the application configuration file.
        public StudentsContext()
            : base("name=StudentsDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Trainer> Trainers { get; set; }
         public virtual DbSet<Auditory> Auditories { get; set; }
         public virtual DbSet<Schedule> Schedules { get; set; }
         public virtual DbSet<Course> Courses { get; set; }

    }
       
}