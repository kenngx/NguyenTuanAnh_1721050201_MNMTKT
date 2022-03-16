using EFCore.BulkExtensions;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public class StudentService : IStudentService
    {
        MvcMovieContext _dbContext = null;
        public StudentService(MvcMovieContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
        }

        public List<Student> SaveStudents(List<Student> students)
        {
            _dbContext.BulkInsert(students);
            return students;
        }
    }
}
