
using System;

namespace PrototypeDesignPattern
{
    internal class ContractorEmployee : Employee
    {
        public override Employee GetClone()
        {
            return (ContractorEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine($" Name:{this.Name} and Department: {this.Department}");
        }
    }
}
