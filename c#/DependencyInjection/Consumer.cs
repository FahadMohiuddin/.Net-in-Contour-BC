using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Consumer
    {
        private IDependency _myDependancy;
        public Consumer(IDependency myDependancy)
        {
            _myDependancy = myDependancy;
        }

        public void ConsumerThings()
        {
            _myDependancy.writeMessage("Consumer Class");
        }
    }
}
