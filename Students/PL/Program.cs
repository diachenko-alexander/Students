using BLL.Configuration;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using System;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfiguration.Initialize();
            IService<StudentDTO> studentService = new StudentServises();

            //Create Student
            var student1 = new StudentDTO { FirstName = "Alex", LastName = "Diachenko", Birthday = new DateTime(1982, 10, 26), Email = "alex@mail.com", Phone = "123456789" };
            studentService.Create(student1);
            var allStudents = studentService.GetAll();

            foreach (var item in allStudents)
            {
                Console.WriteLine($"{item.Id} {item.FirstName}");
            }
            Console.ReadLine();
            
            // Update Student
            //var studentToUpdate = student1;
            //studentToUpdate.Id = 1;
            //studentToUpdate.FirstName = "Denis";
            //studentService.Update(studentToUpdate);

            //var allStudents2 = studentService.GetAll();

            //foreach (var item in allStudents2)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName}");
            //}
            //Console.ReadLine();

            //studentService.Delete(1);
            //Console.ReadLine();




        }
    }
}
