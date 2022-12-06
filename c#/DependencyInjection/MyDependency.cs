using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MyDependency : IDependency
    {
        public void writeMessage()
        {
            Console.WriteLine("MYDEPENDENCY CLASS");
        }

        public void writeMessage(string message)
        {
            Console.WriteLine($"MyDependancy: {message}");
        }
    }
}
