namespace DAL.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Reflection;

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

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Configurations.Add(new StudentConfig());
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
             .Where(type => !String.IsNullOrEmpty(type.Namespace))
             .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                  && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }

}