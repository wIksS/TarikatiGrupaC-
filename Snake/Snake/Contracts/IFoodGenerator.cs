using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Contracts
{
    public interface IFoodGenerator
    {
        Food GenerateFood(IPositionalRenderer renderer);

        void RenderFood();
    }
}
