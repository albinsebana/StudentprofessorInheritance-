using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProffessorDemo.Model
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        // public double Salary { get; set; }

        public Person() { }

        public Person(int id, string address,DateTime dob)
        {
            Id = id;
            Address = address;
            Dob = dob;
            // Salary = salary;
        }
        public virtual string PrintDetails()
        {
            return $"Id : {Id} \n Address : {Address} \n " +
                $"Dob : {Dob}\n ";
        }
    }
}
