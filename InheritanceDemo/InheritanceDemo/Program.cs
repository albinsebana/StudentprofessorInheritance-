using InheritanceDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Man man = new Man();
            //man.Play();
            //man.Work();
            //Console.WriteLine("---------------");
            //Boy boy = new Boy();        
            //boy.Play();
            //boy.Eat();

            //Console.WriteLine("------------------");
            //Toddler toddler = new Toddler();    
            //toddler.Play();
            //toddler.Sleep();
            //Console.WriteLine("------------------");


            //Man m1= new Man();
            //m1.Play();
            

            //Boy boy1=  (Boy)m1;
            //boy1.Eat(); 

            //((Boy)m1).Eat();

            //AtThePark(new Man());
            //AtThePark(new Boy());
            //AtThePark(new Toddler());

            Man man = new Man(28);
            Console.WriteLine("------------------");
            Boy boy = new Boy(14);

        }
        static void AtThePark(Man ob )
        { 
            ob.Play();
            Console.WriteLine("At the Park");
            Console.WriteLine("------------------");
        }
    }
}
