using Domain.Models;
using System.Collections.Generic;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
        List<Student> GetAll();
        List<Student> Search(string searchText);
    }
}
