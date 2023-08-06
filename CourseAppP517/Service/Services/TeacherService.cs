using Domain.Models;
using Repository.Repositories.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private int _count = 1;

        public TeacherService()
        {
            _teacherRepository = new TeacherRepository();
        }

        public void Create(Teacher teacher)
        {
            teacher.Id = _count;
            _teacherRepository.Create(teacher);
            _count++;
        }

        public List<Teacher> GetAll() => _teacherRepository.GetAll();
    }
}
