using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie;

    public class MvcMovieContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=TUANANH\SQLEXPRESS;Initial Catalog=MNM_TKT;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }

        public DbSet<MvcMovie.Models.Movie> Movies { get; set; }

        public DbSet<MvcMovie.Student> Students { get; set; }

        public DbSet<MvcMovie.Person> Persons { get; set; }

        public DbSet<MvcMovie.Employee> Employees { get; set; }

        public DbSet<MvcMovie.Customer> Customers { get; set; }
    }