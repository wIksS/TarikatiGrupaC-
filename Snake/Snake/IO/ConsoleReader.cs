using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadKey()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                return key.Key.ToString();
            }

            return null;
        }
    }
}
