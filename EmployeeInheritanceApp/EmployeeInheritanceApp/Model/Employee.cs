using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritanceApp.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee( int empId, string name, int age, double salary)
        {
            Id = empId;
            Name = name;
            Age = age;
            Salary = salary;
        }
        public virtual string PrintDetails()
        {
            return $"Id : {Id} \n Name : { Name} \n " +
                $"Salary : { Salary}\n ";
        }
    }
}
