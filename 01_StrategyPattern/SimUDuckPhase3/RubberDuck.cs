using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase3
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Rubber duck display");
        }
    }
}
