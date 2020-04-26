namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.StudentsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DAL.Context.StudentsContext";
        }

        protected override void Seed(DAL.Context.StudentsContext context)
        {
            
        }
    }
}
