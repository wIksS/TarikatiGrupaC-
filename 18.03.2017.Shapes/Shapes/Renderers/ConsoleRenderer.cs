using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Abstraction
{
    public class ConsoleRenderer : IRenderer
    { 
        public void Write(object input)
        {
            Console.Write(input);        
        }

        public void WriteAt(object input, Position position)
        {
            Console.SetCursorPosition(position.Col, position.Row);
            this.Write(input);
        }

        public void WriteLine(object input)
        {
            Console.WriteLine(input);
        }
    }
}
