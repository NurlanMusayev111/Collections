using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_12nov_Practice.Controllers
{
    public class EmployeeControllers
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeControllers()
        {
            _employeeService = new EmployeeService();
        }

        public void GetFilter()
        {
            DateTime startDate = new(1993, 01, 01);
            DateTime endDate = new(2005, 01, 01);
            double salary = 3000;

            var result = _employeeService.GetFilterEmployee(startDate, endDate, salary);

            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Surname}");
            }
        }
    }
}
