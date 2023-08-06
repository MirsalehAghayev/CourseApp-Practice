using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System.Collections.Generic;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private int _count = 1;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void Create(Student student)
        {
            student.Id = _count;
            _studentRepository.Create(student);
            _count++;
        }

        public List<Student> GetAll() => _studentRepository.GetAll();

        public List<Student> Search(string searchText)
        {
            return _studentRepository.Search(searchText);
        }
    }
}
