using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase3.IService;

namespace _01_StrategyPattern.SimUDuckPhase3
{
    public class RedHeadDuck : Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Red head duck display");
        }

        public void Fly(string duckName)
        {
            Console.WriteLine(duckName + " is flying.");
        }

        public void Quack(string duckName)
        {
            Console.WriteLine(duckName + " is quacking");
        }
    }
}
