using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            var number = Convert.ToInt32(Console.ReadLine());
            isPrime(number);

             void isPrime(int num)
            {
                bool flag = false;

                if (num == 0 || num == 1)
                {
                    flag = true;
                }
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("{0} is a Prime Number",num);
                }
                else
                {
                    Console.WriteLine("{0} is not a Prime Number",num);
                }
            }
        }
    }
}
