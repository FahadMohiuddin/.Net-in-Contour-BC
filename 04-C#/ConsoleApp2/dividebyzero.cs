using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class dividebyzero
    {
        public void dividebyz() {

            int a = 1;
            int b = 0;
             
            try
            {
                int c = a / b;    
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occurred");
            }

        }
    }
}
