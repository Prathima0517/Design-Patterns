
using System;

namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee()
            {
                Name = "PermanentEmployee",
                Department = "IT",               
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();


            Employee emp3 = new ContractorEmployee()
            {
                Name = "ContractorEmployee",
                Department = "HR"
            };
            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            Console.Read();
        }
    }
}
