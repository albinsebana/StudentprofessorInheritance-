using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Man
    {

        public Man()
        {
            Console.WriteLine("Defaulkt Constructor of Man");
        }
        public Man(int age)
        {
            int ManAge = age;
            Console.WriteLine("Parametrized constroctor of Man is  called");
        }

        public virtual void Play()
        {
            Console.Write("Man plays ");
        }
        public void Work()
        {
            Console.WriteLine("Man Works ");

        }
    }
}
