using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        public CourseDTO Course { get; set; }
        public PeopleDTO Trainer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
