using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_12nov_Practice.Controllers
{
    public class AccountController
    {
        private readonly IUserService _userService;

        public AccountController()
        {
            _userService = new UserService();
        }

        public bool Login()
        {
            Console.WriteLine("Enter your email :");
            Email: string email = Console.ReadLine();

            Console.WriteLine("Enter your password :");
            string password = Console.ReadLine();   

            bool response = _userService.Login(email, password);

            if(!response)
            {
                Console.WriteLine("Email is password is wrong,please enter again");
                goto Email;
            }

            return true;

        }
    }
}
