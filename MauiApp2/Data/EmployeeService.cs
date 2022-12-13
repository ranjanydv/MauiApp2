using MauiApp2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    public class EmployeeService
    {
        public List<EmployeeModel> EmployeeDetails()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>()
            {
                new EmployeeModel(){FirstName="Ranjan",LastName="Yadav",Designation="Manager",StartDate=DateTime.Now,Salary=120000},
                new EmployeeModel(){FirstName="Samiksha",LastName="Bhandari",Designation="CEO",StartDate=DateTime.Now,Salary=240000},
                new EmployeeModel(){FirstName="Apple",LastName="Ball",Designation="Cat",StartDate=DateTime.Parse("10/04/2021"),Salary=120000},
            };
            return employeeList;
        }

        public List<EmployeeModel> GetEmployeeData(string name)
        {
            var employeeList = EmployeeDetails();
            var designation = employeeList.Where(x => x.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            return designation;
        }

    }
}
