using System;

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
