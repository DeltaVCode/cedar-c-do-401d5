using System;

namespace Demo
{
    class Baseball : Sport, IHasTeams
    {
        public Baseball(string name) : base(name)
        {
        }

        public override bool IsIndoors => false; // shortcut for get { return false; }

        public int TeamCount { get; } = 2;
        public string[] TeamNames { get; set; }

        public override string[] GetEquipment()
        {
            return new string[]
            {
                "Baseball",
                "Bats",
                "Gloves",
                "Big League Chew",
            };
        }

        public override void PrintRules()
        {
            Console.WriteLine("Scratch yourself");
        }
    }
}
