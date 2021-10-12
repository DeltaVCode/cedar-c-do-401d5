using System;

namespace Demo
{
    abstract class Sport : Game // extends Game
    {
        public Sport(string name)
        {
            Name = name;
        }

        public abstract string[] GetEquipment();
    }

    abstract class Tennis : Sport
    {
        protected Tennis() : base("Tennis")
        {
        }

        public string Surface { get; set; }

        public override string[] GetEquipment()
        {
            return new string[] { "Balls", "Racket", "Net" };
        }

        public override void PrintRules()
        {
            Console.WriteLine("Play tennis.");
        }
    }

    class SinglesTennis : Tennis
    {
        public override bool IsIndoors { get; }

        public override void PrintRules()
        {
            base.PrintRules();
            Console.WriteLine("One on one");
        }
    }

    class DoublesTennis : Tennis, IHasTeams
    {
        public DoublesTennis(string team1, string team2)
        {
            TeamNames = new[] { team1, team2 };
        }

        public override bool IsIndoors { get; } = false;
        public int TeamCount { get; } = 2;
        public string[] TeamNames { get; set; }
    }

    class Golf : Sport
    {
        public Golf() : base("Walking Around")
        {
        }

        public override bool IsIndoors => false;

        public override string[] GetEquipment()
        {
            return new[] { "Balls", "Clubs" };
        }

        public override void PrintRules()
        {
            Console.WriteLine("Walk around and swing metal at ball.");
        }
    }

    interface IHasTeams
    {
        int TeamCount { get; }

        string[] TeamNames { get; set; }
    }
}
