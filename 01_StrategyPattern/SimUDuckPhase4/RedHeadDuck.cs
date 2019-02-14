using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(IFlyable flyable, IQuackable quackable)
            : base(flyable, quackable)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Red head duck display");
        }
    }
}
