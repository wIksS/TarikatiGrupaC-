using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfConstructions
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool isFive = number == 5;

            if (isFive)
            {
                Console.WriteLine("Number is five!");
            }
            else if (number == 6)
            {
                Console.WriteLine("Number is six");
            }
            else if (number < 100)
            {
                Console.WriteLine("Number is less than 100");
            }
            else
            {
                Console.WriteLine("Number is bigger or equal than 100");
            }            
        }
    }
}
