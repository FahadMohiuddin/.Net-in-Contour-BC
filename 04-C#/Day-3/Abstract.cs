using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
   
               abstract class Animal
        {
            public abstract void eat();
            public abstract void sound();
        }

        class Cat : Animal
        {
            public override void sound()
            {

            }
            public override void eat()
            {
                Console.WriteLine("Milk");
            }
        }

        class Dog : Animal
        {
            public override void sound()
            {
                Console.WriteLine("Bark Bark");
            }
            public override void eat()
            {
                Console.WriteLine("Dog Food");
            }

        }
    
}
