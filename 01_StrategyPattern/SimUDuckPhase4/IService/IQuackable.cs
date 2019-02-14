using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase4.IService
{
    public interface IQuackable
    {
        void Quack(string duckName);
    }
}
