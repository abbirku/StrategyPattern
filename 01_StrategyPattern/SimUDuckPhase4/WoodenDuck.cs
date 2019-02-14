using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck(IFlyable flyable, IQuackable quackable)
            : base(flyable, quackable)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Wooden duck display");
        }
    }
}
