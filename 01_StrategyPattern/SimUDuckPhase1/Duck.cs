using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase1
{
    public abstract class Duck
    {
        public Duck()
        {
            //Console.WriteLine("Duck super class");
        }

        public void Quack()
        {
            Console.WriteLine("Duck is quacking");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swiming");
        }

        public abstract void Display();
    }
}
