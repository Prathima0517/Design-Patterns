using System;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singletonClass1 = SingletonClass.GetSingletonInstance();

            //Returns old instance for 2nd time also
            SingletonClass singletonClass2 = SingletonClass.GetSingletonInstance();
            Console.ReadLine();
        }
    }
}
