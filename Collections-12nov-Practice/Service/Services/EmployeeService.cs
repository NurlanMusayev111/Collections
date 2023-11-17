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
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetFilterEmployee(DateTime start, DateTime end, double salary)
        {
            return AppDbContext.Employees().Where(m => m.Birthday > start && m.Birthday < end && m.Salary > salary).ToList();
        }
    }
}
