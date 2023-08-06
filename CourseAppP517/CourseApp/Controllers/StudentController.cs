using Service.Services;
using Service.Services.Interfaces;
using Service.Helpers.Extetions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace CourseApp.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add student full name:");
            string fullName = Console.ReadLine();

            ConsoleColor.Cyan.WriteConsole("Add student address:");
            string address = Console.ReadLine();

            Student student = new()
            {
                FullName = fullName,
                Address = address
            };

            _studentService.Create(student);

            ConsoleColor.Green.WriteConsole("Student create is success");
        }

        public void GetAll()
        {
            foreach (Student student in _studentService.GetAll())
            {
                string data = $"{student.Id} - {student.FullName} - {student.Address}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }

        public void Search()
        {
            ConsoleColor.Cyan.WriteConsole("Add search text:");
            string search = Console.ReadLine();
            foreach (Student student in _studentService.Search(search))
            {
                string data = $"{student.Id} - {student.FullName} - {student.Address}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }
    }
}
