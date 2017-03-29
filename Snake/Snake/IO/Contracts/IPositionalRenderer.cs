using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Contracts
{
    public interface IPositionalRenderer
    {
        void WriteAtPosition(Coordinate coordinate, object input);

        void Clear();

        void PrintGameOver();
    }
}
