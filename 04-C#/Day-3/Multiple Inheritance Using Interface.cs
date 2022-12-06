using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Multiple_Inheritance_Using_Interface
    {

        //Multiple Inheritance using Interfaces

        interface DesiFood
        {
            public void DesiDishes();
        }
        interface WesternFood
        {
            public void WesternDishes();
        }

        public class Foods : DesiFood{
            public void DesiDishes()
            {
                Console.WriteLine("Tikka, Karhai");
            }

            public void WesternDishes()
            {
                Console.WriteLine("Zinger Burger");
            }
        }


    }
}
