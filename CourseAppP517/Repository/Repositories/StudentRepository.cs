using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public List<Student> Search(string text)
        {
            return AppDbContext<Student>.datas.Where(m => m.FullName.ToLower().Contains(text.ToLower())).ToList();
        }
    }
}
