using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //The below commented code was replaced by the simple version because of the Lazy keyword on line 13. In this approach GetInstance returns instance which is the object initialisation of Singleton and has been initialised once only. Due to lazy it is also multi thread protected.
    public sealed class Singleton
    {
        private static int count = 0;
        private Singleton()
        {
            count++;
            Console.WriteLine("Class initiated " + count + " time!");
        }
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            /*get
            {
                //The below is called double check locking. lock is used to avoid initialisation of the object twice in case of multi threading, and the if statement outside lock is used to avoid entering lock unneccesiraly as it will be inefficient.
                if(instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                
                return instance;
            }*/

            get
            {
                return instance.Value;
            }
        }
        public void print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
