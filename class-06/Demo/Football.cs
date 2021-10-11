﻿using System;

namespace Demo
{
    class Football : Sport // Concrete class, not abstract
    {
        // Default constructor (no parameters)
        public Football() : base("Football") // call base ctor with name
        {
        }

        public override bool IsIndoors
        {
            get { return false; } // not actually a good abstraction
        }

        public override string[] GetEquipment()
        {
            return new string[]
            {
                "Football",
                "Concusion-willing participants",
            };
        }

        public override void PrintRules()
        {
            Console.WriteLine("Four downs. Ten yards. Times ten. Touchdown.");
            Console.WriteLine("Refs wear black and white.");
        }
    }
}
