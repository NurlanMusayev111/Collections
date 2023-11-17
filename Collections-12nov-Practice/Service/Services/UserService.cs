using Domain.Models;
using Service.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        public bool Login(string mail, string password)
        {
            return  AppDbContext.Users().Exists(m => m.Email == mail && m.Password == password);
        }        
    }
}
