using System;

namespace SingletonDesignPattern
{
    //sealed -- to prevent class inheritances
    //members of a sealed class can sometimes be faster because the method dispatching process is simpler
    //and can be more efficiently optimized during JIT (Just-In-Time) compilation.
    public sealed class SingletonClass
    {      
        private static SingletonClass _instance;
        private static readonly object _lockObject = new object();
        private static int _counter=0;
        private SingletonClass() {
            _counter++;
            Console.WriteLine($"Singleton class called for {_counter} times");
        }
        public static SingletonClass GetSingletonInstance()
        {
            //lock object is used for thread safety 
            // If lock is not used-- and parallel method invoked for getting instance then we get race condition
            lock (_lockObject)
            {
                if (_instance == null)
                {
                    Console.WriteLine("New instance is created");  
                    _instance = new SingletonClass();
                    return _instance;
                }
            }
            Console.WriteLine("Returning old instance");
            return _instance;
            
        }
    }
}
