using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        List<Employee> SaveEmployees(List<Employee> employees);
    }
    
}
