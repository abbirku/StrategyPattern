using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4.Service
{
    public class Spack : IQuackable
    {
        public void Quack(string duckName)
        {
            Console.WriteLine(duckName+" is speacking.");
        }
    }
}
