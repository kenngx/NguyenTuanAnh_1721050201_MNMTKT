using EFCore.BulkExtensions;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public class CustomerService : ICustomerService
    {
        MvcMovieContext _dbContext = null;
        public CustomerService(MvcMovieContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public List<Customer> SaveCustomers(List<Customer> customers)
        {
            _dbContext.BulkInsert(customers);
            return customers;
        }
    }


}