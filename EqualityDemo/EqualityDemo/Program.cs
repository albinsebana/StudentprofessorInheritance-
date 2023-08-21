using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 10;
            Console.WriteLine("Value-based Equality using ==");
            Console.WriteLine(a == b); //false
            Console.WriteLine(a == c);//true
            Console.WriteLine("Value-based Equality using Equals() on primitive/value types");
            Console.WriteLine(a.Equals(b));//false
            Console.WriteLine(Equals(a, c));//true
            Customer c1 = new Customer(101, "Allen");
            Customer c2 = new Customer(101, "Alan");
            Customer c3 = c1;
            Console.WriteLine("Referential Equality using ==");
            Console.WriteLine(c1 == c2); //false
            Console.WriteLine(c1 == c3);//true

            Console.WriteLine("Value-based Equality using Equals() on reference types"); 
            Console.WriteLine(c1.Equals(c2));//ideally true, needs to be overridden
            Console.WriteLine(c1.Equals(c3));//true
        }
    }
}
