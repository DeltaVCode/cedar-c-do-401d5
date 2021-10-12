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
            // fb.TeamCount = 2;
            fb.TeamNames = new[] { "Packers", "Bears" };
            fb.PlayerCount = 22;
            fb.PrintSummary();
            fb.PrintRules();

            Console.WriteLine("Sports!");
            Sport[] sports = new Sport[]
            {
                fb,
                new Golf(DateTime.Now),
                new Baseball("Little League"),
                new Baseball("MLB"),
                new Golf(DateTime.Now.AddHours(36)),
                new DoublesTennis("Venus/Serena", "Losers"),
                new SinglesTennis(),
                new Football{TeamNames = new[]{"Saints", "Dolphins"}},
            };

            for (int i = 0; i < sports.Length; i++)
            {
                Sport sport = sports[i];

                Console.WriteLine($"Name: {sport.Name}");

                if (sport is IHasTeams teamSport) // new variable teamSport
                {
                    Console.WriteLine("Team Count: {0}", teamSport.TeamCount);
                }
                else
                {
                    Console.WriteLine("Solo sport!");
                }

                if (sport is Golf golfGame)
                {
                    Console.WriteLine("Tee Time is {0}", golfGame.TeeTime);
                }

                sport.PrintSummary();
                sport.PrintRules();
            }

            Euchre cg = new Euchre();
            // cg.Name = "Euchre!"; // Inaccessible
            PrintCardGame(cg);

            PrintTeams(cg);

            ProgrammingContest pc = new ProgrammingContest();
            PrintTeams(pc);
        }

        static void PrintCardGame(CardGame cg)
        {
            Console.WriteLine(cg); // ToString() is virtual
            Console.WriteLine("Card Count: {0}", cg.CardCount);
            Console.WriteLine("--------------");
            cg.PrintRules();
        }

        static void PrintTeams(IHasTeams somethingWithTeams)
        {
            Console.WriteLine($"There are {somethingWithTeams.TeamCount} teams involved.");

            if (somethingWithTeams.TeamNames == null)
                return; // skip writing teams

            Console.WriteLine("Teams:");
            foreach (string team in somethingWithTeams.TeamNames)
            {
                Console.WriteLine("- " + team);
            }
        }
    }

    class ProgrammingContest : IHasTeams
    {
        public int TeamCount { get; } = 50;
        public string[] TeamNames { get; set; }
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

    class Euchre : CardGame, IHasTeams
    {
        public override int CardCount => 24;

        public int TeamCount { get; } = 2;
        public string[] TeamNames { get; set; }

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
