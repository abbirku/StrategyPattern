using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4.Service
{
    public class FlyNoWay : IFlyable
    {
        public void Fly(string duckName)
        {
            Console.WriteLine(duckName + " can fly. No Way.");
        }
    }
}
