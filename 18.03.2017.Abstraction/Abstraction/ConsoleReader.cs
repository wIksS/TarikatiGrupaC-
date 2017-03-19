using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ConsoleReader : IReader
    {
        public override string Read()
        {
            return Console.Read().ToString();
        }

        public override string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
