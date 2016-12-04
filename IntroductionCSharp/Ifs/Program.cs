using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            byte byteNumber = 255;
            sbyte sByteNumber = 127;

            short shortNumber = 32000;
            ushort ushortNumber = 60000;

            int intNumber = 2147000000;
            uint uintNumber = 4000000000;

            long longNumber = long.MinValue;
            ulong ulongNumber = ulong.MaxValue;

            float floatNumber = (float) 0;
            double doubleNumber = 5.556666666566666666656565666666;
            decimal decimalNumber = (decimal)5.656565656565656565;

            Console.WriteLine("Int max value: " + int.MaxValue);
           
            Console.WriteLine("Byte number: " + byteNumber);
            Console.WriteLine("Signed byte number: " + sByteNumber);
            Console.WriteLine("Short number: " + shortNumber);
            Console.WriteLine("Unsigned short number: " + ushortNumber);
            Console.WriteLine("Integer number: " + intNumber);
            Console.WriteLine("Unsigned integer number: " + uintNumber);
            Console.WriteLine("Long min number: " + longNumber);
            Console.WriteLine("ULong max value: " + ulongNumber);

            Console.WriteLine("Float number: " + floatNumber);
            Console.WriteLine("Double number: " + doubleNumber);
            Console.WriteLine("Decimal number: " + decimalNumber);
        }
    }
}
