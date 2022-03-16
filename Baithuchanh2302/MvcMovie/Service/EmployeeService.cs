using EFCore.BulkExtensions;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public class EmployeeService : IEmployeeService
    {
        MvcMovieContext _dbContext = null;
        public EmployeeService(MvcMovieContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public List<Employee> SaveEmployees(List<Employee> employees)
        {
            _dbContext.BulkInsert(employees);
            return employees;
        }
    }
    
      
}