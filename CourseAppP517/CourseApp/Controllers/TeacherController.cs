using Domain.Models;
using Service.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Helpers.Extetions;

namespace CourseApp.Controllers
{
    internal class TeacherController
    {
        private readonly ITeacherService _teacherService;

        public TeacherController()
        {
            _teacherService = new TeacherService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add teacher full name:");
            string fullName = Console.ReadLine();

            ConsoleColor.Cyan.WriteConsole("Add teacher email:");
            string email = Console.ReadLine();

            Teacher teacher = new()
            {
                FullName = fullName,
                Email = email
            };

            _teacherService.Create(teacher);

            ConsoleColor.Green.WriteConsole("Teacher create is success");
        }

        public void GetAll()
        {
            foreach (Teacher teacher in _teacherService.GetAll())
            {
                string data = $"{teacher.Id} - {teacher.FullName} - {teacher.Email}";
                ConsoleColor.DarkMagenta.WriteConsole(data);
            }
        }

    }
}
