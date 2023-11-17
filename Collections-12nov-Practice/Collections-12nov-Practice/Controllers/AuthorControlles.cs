using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_12nov_Practice.Controllers
{
    public class AuthorControlles
    {
        private readonly IAuthorService _authorService;

        public AuthorControlles()
        {
            _authorService = new AuthorService();
        }

        public void GetAuthorByAge()
        {
            int age = 25;

            var result = _authorService.GetAllByAge(age);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Surname} - {item.Age}" );
            }
        }
    }
}
