using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        public abstract class Animal
        {
            public string Name { get; set; }
            public Animal()
            {
                
            }

            public virtual void Run()
            {
                Console.WriteLine("Animal is running");
            }

            public abstract void Run1();
        }

        class Dog : Animal
        {
            public override void Run1()
            {
                Console.WriteLine("Run 1 abstract Dog is running");
            }
            public override void Run()
            {
                Console.WriteLine("Dog is running ");
            }
        }

        class Cat : Animal
        {
            public override void Run1()
            {
                Console.WriteLine("Run 1 abstract Cat is running");
            }
        }

        class Lion : Animal
        {
            public override void Run1()
            {
                Console.WriteLine("Runr1 abstract : Lion is running");
            }
            public override void Run()
            {
                Console.WriteLine("Lion is running");
            }
        }
    }
}
