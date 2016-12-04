using System;

namespace SumOfTwoNumbers
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum is: " + (firstNumber + secondNumber));
        }
    }
}
