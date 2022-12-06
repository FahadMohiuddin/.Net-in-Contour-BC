using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class MyDependency2 : IDependency
    {
        public void writeMessage(string message)
        {
            Console.WriteLine($"MyDependency2: {message}");
        }
    }
}
