using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        List<Customer> SaveCustomers(List<Customer> customers);
    }
}