using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        public void Cal()
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operator");
                string c = Console.ReadLine();



                if(c=="+" || c=="-" || c=="*" || c == "/")
                {
                    if (c == "+")
                    {
                        Console.WriteLine(a + b);
                    }
                    else if (c == "-")
                    {
                        Console.WriteLine(a - b);

                    }
                    else if (c == "*")a
                    {
                        Console.WriteLine(a * b);

                    }
                    else if (c == "/")
                    {
                        Console.WriteLine(a / b);

                    }

                }
                else
                {
                    throw new ArgumentException();
                        
                  }

            }

            catch(Exception e) {

                Console.WriteLine("Error");
            }


        }
    }
}
