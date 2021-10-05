using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FizzBuzzer fb = new FizzBuzzer();

            for (int n = 0; n <= 100; n++)
            {
                Console.WriteLine(fb.FizzBuzz(n));
            }
        }
    }
}
