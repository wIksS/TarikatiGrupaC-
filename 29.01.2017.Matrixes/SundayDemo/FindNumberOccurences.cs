using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundayDemo
{
    class FindNumberOccurences
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = InputArray(n);
            Print(array, true);
            Console.WriteLine("Enter the searched number!");
            int searchedNumber = int.Parse(Console.ReadLine());
            int occurences = FindNumberOccurencesInArray(array, searchedNumber);
            Console.WriteLine("Number is found: {0} times", occurences);
        }

        static int FindNumberOccurencesInArray(int[] array, int searchedNumber)
        {
            int counter = 0;

            foreach (var item in array)
            {
                if (item == searchedNumber)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Print(int[] array, bool printLines = false)
        {
            foreach (var item in array)
            {
                if (printLines == true)
                {
                    Console.WriteLine(new string('-',50));
                    Console.WriteLine(item);
                }
                else
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
        }

        static int[] InputArray(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }
    }
}
