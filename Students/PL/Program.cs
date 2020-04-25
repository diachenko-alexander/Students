using System;
using BLL.Services;
using BLL.DTO;
using BLL.Configuration;



namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfiguration.Initialize();
            
            ////Create Student
            //PeopleDTO st1 = new PeopleDTO { FirstName = "Alex", LastName = "Diachenko", Birthday = new DateTime(1982,10,26), Email = "alex@mail.com", Phone = "123456789" };
            //StudentServises studentServises = new StudentServises();
            //studentServises.CreateStudent(st1);

            //// Create Courses
            //CourseDTO cSharpStarter = new CourseDTO { Name = "C# Starter", Hours = 20 };
            //CourseDTO cSharpEssential = new CourseDTO { Name = "C# Essential", Hours = 30 };
            //CourseDTO cSharpProffesional = new CourseDTO { Name = "C# Proffesional", Hours = 30 };

            //CourseService courseService = new CourseService();
            //courseService.CreateCourse(cSharpStarter);
            //courseService.CreateCourse(cSharpEssential);
            //courseService.CreateCourse(cSharpProffesional);

            //// Create Trainer
            //PeopleDTO tr1 = new PeopleDTO { FirstName = "Serg", LastName = "Ivanov", Birthday = new DateTime(1990, 10, 26), Email = "serg@mail.com", Phone = "0991234567" };
            //PeopleDTO tr2 = new PeopleDTO { FirstName = "Ivan", LastName = "Petrov", Birthday = new DateTime(1988, 11, 26), Email = "serg@mail.com", Phone = "0991234567" };
            //TrainerService trainerService = new TrainerService();
            //trainerService.CreateTrainer(tr1);
            //trainerService.CreateTrainer(tr2);

            ////Create Schedule
            //ScheduleDTO scheduleCSharpStarter = new ScheduleDTO { CourseId = cSharpStarter.Id, Trainer = tr1,  StartDate = new DateTime(2020, 06, 01), FinishDate = new DateTime(2020, 07, 15) };
            //ScheduleDTO scheduleCSharpEssential = new ScheduleDTO { CourseId = cSharpEssential.Id, Trainer = tr1, StartDate = new DateTime(2020, 07, 05), FinishDate = new DateTime(2020, 07, 15) };
            //ScheduleService scheduleService = new ScheduleService();
            //scheduleService.CreateSchedule(scheduleCSharpStarter);
            //scheduleService.CreateSchedule(scheduleCSharpEssential);


        }
    }
}
