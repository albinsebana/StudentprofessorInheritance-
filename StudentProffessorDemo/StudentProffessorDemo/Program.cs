using StudentProffessorDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StudentProffessorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowDetails(new Professor(201, "Mumbai ,Dharavi ", new DateTime(1989, 5, 15),1000));
            ShowDetails(new Student(3001, "Kerala, Kochi", new DateTime(2000, 5, 8), branch: "Bcom"));
        }
        static void ShowDetails(Person person)
        {
            Console.WriteLine($"========== Role: {person.GetType().Name} ============");
            Console.WriteLine(person.PrintDetails());
        }
    }
}