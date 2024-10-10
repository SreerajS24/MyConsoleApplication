using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string userInput = Console.ReadLine();
            int firstNumber = int.Parse(userInput);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Enter the second number");
            userInput = Console.ReadLine();
            int secondNumber = int.Parse(userInput);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Enter the third number");
            userInput = Console.ReadLine();
            int thirdNumber = int.Parse(userInput);

            Console.WriteLine(Environment.NewLine);

            var sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"Sum of the values : {sum}");

            var product = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"Product of the values : {product}");

            var average = sum / 3.0;
            Console.WriteLine($"Average of the sum : {average:N1}");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Before (X = {firstNumber}, y= {secondNumber}, z={thirdNumber})");

            Console.WriteLine("Is first number greater than equal to the second number ? : {0}", firstNumber >= secondNumber);

            firstNumber += secondNumber - firstNumber++ * thirdNumber;
            Console.WriteLine($"firstnumber calculated : {firstNumber}");

            int result = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"Max value between first and second: {result}");

            secondNumber /= firstNumber + 5 % thirdNumber;
            Console.WriteLine($"secondNumber calculated : {secondNumber}");

            Console.WriteLine($"After (X = {firstNumber}, y= {secondNumber}, z={thirdNumber})");

            Nullable<int> variable = null;
            Console.WriteLine(variable);

            Console.ReadLine();

        }
    }
}
