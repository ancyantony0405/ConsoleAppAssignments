﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Model
{
    public class Dog : Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Dogs Say Bow Wow");
        }
    }
}
