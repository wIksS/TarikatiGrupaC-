using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter searched number: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ,", array));

            Array.Sort(array);

            int start = 0;
            int end = array.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == searchedNumber)
                {
                    Console.WriteLine("Found element at {0}", mid);
                    break;
                }
                else if (array[mid] > searchedNumber)
                {
                    end = mid - 1;
                }
                else if(array[mid] < searchedNumber)
                {
                    start = mid + 1;
                }
            }
        }
    }
}
