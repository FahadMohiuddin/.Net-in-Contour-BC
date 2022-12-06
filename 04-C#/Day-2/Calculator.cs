using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class calculator
    {

        public int add(int a, int b)
        {
            return a + b;
        }

        //Polymorphism Overloading
        public int add(string a, string b, string c)
        {
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            int z = Convert.ToInt32(c);

            return x+y+z;
        }
        






        //public int sub(int a, int b)
        //{
        //    return a - b;
        //}
        //public int div(int a, int b)
        //{
        //    return a / b;
        //}
        //public int mul(int a, int b)
        //{
        //    return a * b;
        //}
    }
}
