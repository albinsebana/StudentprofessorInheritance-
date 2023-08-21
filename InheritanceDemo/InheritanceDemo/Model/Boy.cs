using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Boy:Man

    {
        public Boy() 
        {
            Console.WriteLine("Defaulkt Constructor of Boy");
           
        }
        public Boy(int age)
        {
            int boYage = age;
            Console.WriteLine("Parametrized constroctor of Boy is called");
            Console.WriteLine("------------------");
        }

        public override void Play()//methpd overriding
        {
            Console.Write("Boy plays ");
        }
        public void Eat() 
        {

            Console.WriteLine("Boy Eats ");
        }
    }
}
