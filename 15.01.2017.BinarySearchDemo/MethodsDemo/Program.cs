using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",firstNumber, secondNumber, SumNumbers(firstNumber, secondNumber));
        }

        static int SumNumbers(int firstNumber, int secondNumber)
        {
            int resultSum = firstNumber + secondNumber;
            return resultSum;
        }
    }
}
