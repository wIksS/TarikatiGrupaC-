using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class IReader
    {
        public abstract string Read();

        public abstract string ReadLine();

        public string EarthName()
        {
            return "Zemq";
        }
    }
}
