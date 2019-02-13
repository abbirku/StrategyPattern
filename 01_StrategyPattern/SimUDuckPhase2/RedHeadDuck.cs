using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase2
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Red head duck display");
        }
    }
}
