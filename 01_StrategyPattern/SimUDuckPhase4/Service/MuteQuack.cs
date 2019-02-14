using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4.Service
{
    public class MuteQuack : IQuackable
    {
        public void Quack(string duckName)
        {
            Console.WriteLine(duckName+" can not quack.");
        }
    }
}
