using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IRenderer
    {
        void Write(object input);

        void WriteLine(object input);
    }
}
