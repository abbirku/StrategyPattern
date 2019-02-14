using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            mallDuck.Quack();
            mallDuck.Swim();
            mallDuck.Display();
            redDuck.Quack();
            redDuck.Swim();
            redDuck.Display();
            rubberDuck.Quack();
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

            //Phase three
            var mallDuck3 = new SimUDuckPhase3.MallardDuck();
            var redDuck3 = new SimUDuckPhase3.RedHeadDuck();
            var rubberDuck3 = new SimUDuckPhase3.RubberDuck();
            var woodenDuck3 = new SimUDuckPhase3.WoodenDuck();

            mallDuck3.Quack("mallDuck3");
            mallDuck3.Swim("mallDuck3");
            mallDuck3.Display();
            redDuck3.Quack("redDuck3");
            redDuck3.Swim("redDuck3");
            redDuck3.Fly("redDuck3");
            redDuck3.Display();
            rubberDuck3.Quack("rubberRuck3");
            rubberDuck3.Swim("rubberRuck3");
            rubberDuck3.Display();
            woodenDuck3.Swim("woodenDuck3");
            woodenDuck3.Display();

            Console.WriteLine("\n\n");

            //Phase four
            var mallDuck4 = new SimUDuckPhase4.MallardDuck(new SimUDuckPhase4.Service.FlyNoWay(), new SimUDuckPhase4.Service.Quack());
            var redDuck4 = new SimUDuckPhase4.RedHeadDuck(new SimUDuckPhase4.Service.FlyWithWings(), new SimUDuckPhase4.Service.Quack());
            var rubberDuck4 = new SimUDuckPhase4.RubberDuck(new SimUDuckPhase4.Service.FlyNoWay(), new SimUDuckPhase4.Service.Spack());
            var woodenDuck4 = new SimUDuckPhase4.WoodenDuck(new SimUDuckPhase4.Service.FlyNoWay(), new SimUDuckPhase4.Service.MuteQuack());

            mallDuck4.PerformQuack("mallDuck4");
            mallDuck4.Swim("mallDuck4");
            mallDuck4.PerformFly("mallDuck4");
            mallDuck4.Display();
            
            redDuck4.PerformQuack("redDuck4");
            redDuck4.Swim("redDuck4");
            redDuck4.PerformFly("redDuck4");
            redDuck4.Display();

            rubberDuck4.PerformQuack("rubberDuck4");
            rubberDuck4.Swim("rubberDuck4");
            rubberDuck4.PerformFly("rubberDuck4");
            rubberDuck4.Display();

            woodenDuck4.PerformQuack("woodenDuck4");
            woodenDuck4.Swim("woodenDuck4");
            woodenDuck4.PerformFly("woodenDuck4");
            woodenDuck4.Display();

            Console.WriteLine("\n\n");
        }
    }
}
