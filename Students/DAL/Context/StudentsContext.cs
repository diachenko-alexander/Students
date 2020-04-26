namespace DAL.Context
{
    using Models;
    using System.Data.Entity;
    using DAL.Configuratons;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new StudentConfig());
        }

    }

}