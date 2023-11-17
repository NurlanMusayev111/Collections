using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author {Id = 1 , Name = "Nurlan" , Surname = "Musayev" , Age =21},
                new Author {Id = 2 , Name = "Nermin" , Surname = "Musayeva" , Age =29},
                new Author {Id = 3 , Name = "Kenan" , Surname = "Elekberli" , Age =20},
                new Author {Id = 4 , Name = "Fidan" , Surname = "Elekberli" , Age =28},
            };
        }


        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee { Name = "Nurlan" , Surname = "Musayev" , Birthday = new DateTime(2002,07,21) ,Salary = 4000},
                new Employee { Name = "Kenan" , Surname = "Elekberli" , Birthday = new DateTime(1997,11,02) ,Salary = 2200},
                new Employee { Name = "Nuru" , Surname = "Eliyev" , Birthday = new DateTime(1995,08,07) ,Salary = 3600},
            };
        }


        public static List<User> Users()
        {
            return new List<User>()
            {
                new User { Id = 1,Email = "nurlan@code.az" , Password = "20062005"},
                new User { Id = 2,Email = "narmin@mail.ru" , Password = "21072002"}
            };
        }

        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product {Name = "iPhone" , Price = 3000, Count = 10},
                new Product {Name = "Samsung" , Price = 2000, Count = 7},
                new Product {Name = "Nokia" , Price = 1200, Count = 5}
            };
        }
    }
}
