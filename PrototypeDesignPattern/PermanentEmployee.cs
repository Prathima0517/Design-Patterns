
using System;

namespace PrototypeDesignPattern
{
    internal class PermanentEmployee : Employee
    {
        public override Employee GetClone()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine($" Name:{this.Name} and Department: {this.Department}");
        }
    }
}
