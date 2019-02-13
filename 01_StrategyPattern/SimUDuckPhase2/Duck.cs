using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase2
{
    public abstract class Duck
    {
        public Duck()
        {
            //Console.WriteLine("Duck super class");
        }

        public void Quick(string duckName)
        {
            Console.WriteLine(duckName + " is quacking");
        }

        public void Swim(string duckName)
        {
            Console.WriteLine(duckName + " is swiming");
        }

        public void Fly(string duckName)
        {
            Console.WriteLine(duckName + " is flying.");
        }

        public abstract void Display();
    }
}
