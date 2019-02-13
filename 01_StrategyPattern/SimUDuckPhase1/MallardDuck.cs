using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase1
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Mallard duck display");
        }
    }
}
