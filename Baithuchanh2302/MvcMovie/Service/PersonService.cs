using EFCore.BulkExtensions;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public class PersonService : IPersonService
    {
        MvcMovieContext _dbContext = null;
        public PersonService(MvcMovieContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Person> GetPersons()
        {
            return _dbContext.Persons.ToList();
        }

        public List<Person> SavePersons(List<Person> persons)
        {
            _dbContext.BulkInsert(persons);
            return persons;
        }
    }
}