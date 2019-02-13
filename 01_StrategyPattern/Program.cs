using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase1;
using _01_StrategyPattern.SimUDuckPhase2;

namespace _01_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phase one
            var mallDuck = new SimUDuckPhase1.MallardDuck();
            var redDuck = new SimUDuckPhase1.RedHeadDuck();
            var rubberDuck = new SimUDuckPhase1.RubberDuck();

            mallDuck.Quick();
            mallDuck.Swim();
            mallDuck.Display();
            redDuck.Quick();
            redDuck.Swim();
            redDuck.Display();
            rubberDuck.Quick();
            rubberDuck.Swim();
            rubberDuck.Display();

            Console.WriteLine("\n\n");

            //Phase two
            var mallDuck2 = new SimUDuckPhase2.MallardDuck();
            var redDuck2 = new SimUDuckPhase2.RedHeadDuck();
            var rubberDuck2 = new SimUDuckPhase2.RubberDuck();

            mallDuck2.Quick("mallDuck2");
            mallDuck2.Swim("mallDuck2");
            mallDuck2.Fly("mallDuck2");
            mallDuck2.Display();
            redDuck2.Quick("redDuck2");
            redDuck2.Swim("redDuck2");
            redDuck2.Fly("redDuck2");
            redDuck2.Display();
            rubberDuck2.Quick("rubberDuck2");
            rubberDuck2.Swim("rubberDuck2");
            rubberDuck2.Fly("rubberDuck2");
            rubberDuck2.Display();

            Console.WriteLine("\n\n");
        }
    }
}
