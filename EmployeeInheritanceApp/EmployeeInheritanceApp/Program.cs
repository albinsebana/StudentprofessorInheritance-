using EmployeeInheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowEmployeeDetails(new Clerk(101, "Albin", 24, 25000, 5000));
            ShowEmployeeDetails(new Manager(101, "Albii", 24, 25000, 5000 ,1000));
        }
        static void ShowEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"========== Role: {employee.GetType().Name} ============");
            Console.WriteLine(employee.PrintDetails());
        }
    }
}
