using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Illegal because Game is abstract
            // Game game = new Game();


            Football fb = new Football();
            fb.TeamCount = 2;
            fb.PlayerCount = 22;
            fb.PrintSummary();
            fb.PrintRules();

            Console.WriteLine("Sports!");
            Sport[] sports = new Sport[]
            {
                fb,
                new Baseball("Little League"),
                new Baseball("MLB"),
            };

            for (int i = 0; i < sports.Length; i++)
            {
                Sport sport = sports[i];

                Console.WriteLine($"Name: {sport.Name}");
                Console.WriteLine("Team Count: {0}", sport.TeamCount);
                sport.PrintSummary();
                sport.PrintRules();
            }

            CardGame cg = new Euchre();
            // cg.Name = "Euchre!"; // Inaccessible
            PrintCardGame(cg);
        }

        static void PrintCardGame(CardGame cg)
        {
            Console.WriteLine(cg); // ToString() is virtual
            Console.WriteLine("Card Count: {0}", cg.CardCount);
            Console.WriteLine("--------------");
            cg.PrintRules();
        }
    }

    abstract class Game
    {
        public string Name { get; protected set; } // Can only assign in child class

        public int PlayerCount { get; set; }

        public abstract bool IsIndoors { get; }

        public abstract void PrintRules();

        public void PrintSummary()
        {
            Console.WriteLine("Player Count: {0}", PlayerCount);
            Console.WriteLine("Indoors? {0}", IsIndoors);
        }
    }

    abstract class CardGame : Game
    {
        // virtual means you *may* override, but don't *have to*
        public virtual int CardCount { get { return 52; } }

        public override bool IsIndoors => true;
    }

    class Euchre : CardGame
    {
        public override int CardCount => 24;

        public override void PrintRules()
        {
            Console.WriteLine("Jacks are good, sometimes");
        }

        public override string ToString()
        {
            return "EUCHRE!!";
        }
    }
}
