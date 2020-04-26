using System;
using System.Data.Entity.ModelConfiguration;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
