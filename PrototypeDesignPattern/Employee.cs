
namespace PrototypeDesignPattern
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
}
