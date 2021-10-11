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
                new Baseball(),
            };

            for (int i = 0; i < sports.Length; i++)
            {
                Sport sport = sports[i];

                Console.WriteLine("Team Count: {0}", sport.TeamCount);
                sport.PrintSummary();
                sport.PrintRules();
            }

        }
    }

    abstract class Game
    {
        public int PlayerCount { get; set; }

        public abstract bool IsIndoors { get; }

        public abstract void PrintRules();

        public void PrintSummary()
        {
            Console.WriteLine("Player Count: {0}", PlayerCount);
            Console.WriteLine("Indoors? {0}", IsIndoors);
        }
    }
}
