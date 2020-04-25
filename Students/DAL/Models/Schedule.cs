using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Schedule
    {
        public int Id { get; set; }
               
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
