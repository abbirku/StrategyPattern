﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StrategyPattern.SimUDuckPhase3.IService;

namespace _01_StrategyPattern.SimUDuckPhase3
{
    public class MallardDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Mallard duck display");
        }

        public void Quack(string duckName)
        {
            Console.WriteLine(duckName + " is quacking");
        }
    }
}
