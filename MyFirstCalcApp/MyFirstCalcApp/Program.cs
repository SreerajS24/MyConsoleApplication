using MessageLibrary;
using System;

namespace MyFirstCalcApp
{
    enum Currencies { USD, SGD, INR }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Messenger messenger = new Messenger();
            //messenger.HelloWorld();
            //Console.ReadLine();

            Console.WriteLine("Enter user first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter user last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Input your year of Experience");
            int yearOfExp = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Good, You have {0} Year of Experience", yearOfExp);
            
            Currencies currency = Currencies.SGD;
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Currency selected {currency} is the currency of Singapore");

            Console.ReadKey();
        }
    }
}
