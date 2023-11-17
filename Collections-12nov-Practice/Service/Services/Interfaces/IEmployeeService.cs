using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetFilterEmployee(DateTime start,DateTime end,double salary);
    }
}
