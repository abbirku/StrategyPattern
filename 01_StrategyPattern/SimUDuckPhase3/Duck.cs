using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern.SimUDuckPhase3
{
    public abstract class Duck
    {
        public Duck()
        {
            //Console.WriteLine("Duck super class");
        }
        
        public void Swim(string duckName)
        {
            Console.WriteLine(duckName + " is swiming");
        }
        
        public abstract void Display();
    }
}
