using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern2
{
    public class Singleton
    {
      
            public int myNumber = 13;

            private static Singleton MySingletonInstance = null;

            private Singleton() { }
            public static Singleton GetInstance()
            {
                if(MySingletonInstance == null){
                MySingletonInstance = new Singleton();
                }
                return MySingletonInstance;
            }
        }

    
}
