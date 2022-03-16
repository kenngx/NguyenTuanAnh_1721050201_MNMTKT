using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Service
{
    public interface IPersonService
    {
        List<Person> GetPersons();
        List<Person> SavePersons(List<Person> persons);
    }
}
