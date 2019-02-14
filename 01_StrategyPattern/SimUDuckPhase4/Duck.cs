using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase4.IService;

namespace _01_StrategyPattern.SimUDuckPhase4
{
    public abstract class Duck
    {
        public IFlyable Flyable { private get; set; }
        public IQuackable Quackable { private get; set; }

        public Duck(IFlyable flyable, IQuackable quackable)
        {
            Flyable = flyable;
            Quackable = quackable;
        }

        public void PerformQuack(string duckName)
        {
            Quackable.Quack(duckName);
        }

        public void Swim(string duckName)
        {
            Console.WriteLine(duckName + " is swiming");
        }

        public void PerformFly(string duckName)
        {
            Flyable.Fly(duckName);
        }

        public abstract void Display();
    }
}
