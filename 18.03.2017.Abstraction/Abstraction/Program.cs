using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new FileRenderer("pesho.txt");
            IReader reader = new ConsoleReader();

            var line = reader.ReadLine();
            renderer.WriteLine(line);
            reader = new FileReader("pesho.txt");
            line = reader.Read();

            renderer = new ConsoleRenderer();
            renderer.WriteLine(line);
        }
    }
}
