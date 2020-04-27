using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuratons
{
    class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            Property(p => p.LastName).IsRequired().HasMaxLength(100);
        }
    }
}
