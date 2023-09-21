using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
{
    public class Person
    {
        public string FullName {get; set;}
        public string Address {get; set;}
        public int Age {get; set;}
        public void nhapthongtin()
        {
            System.Console.WriteLine("Full name = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine("Age");
            Age = Convert.ToInt16(Console.ReadLine());

        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
           
        }
    }
}