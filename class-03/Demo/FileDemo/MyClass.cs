using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class MyClass
    {
        public static void ReadFromFile(string filename)
        {
            WriteToLog("Reading from file!");

            Console.WriteLine("Reading {0}...", filename);

            string fileText = File.ReadAllText(filename);
            Console.WriteLine(fileText);
        }

        public static void OutputEvenLinesFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);

            WriteToLog($"File had {lines.Length} lines!");

            for(int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }

        public static void WriteHi(string filename)
        {
            WriteToLog($"hi");

            File.WriteAllText(filename, "hi");

            Console.WriteLine($"{filename} should say hi:");

            string contents = File.ReadAllText(filename);
            Console.WriteLine(contents);
        }

        public static void WriteNames(string filename)
        {

            string[] names = new string[]
            {
                "Keith",
                "Craig",
                "Marie",
                "Stacey",
                "Aaron",
            };
            // JS = [ ........ ]

            WriteToLog($"writing {names.Length} names");

            // File.WriteAllLines(filename, names);

            // Add to whatever is already in the file
            File.AppendAllLines(filename, names);
        }

        public static void WriteToLog(string message)
        {
            // This doesn't quite work - we want a message per line
            //File.AppendAllText("log.txt", message);

            // Make me a list of one line to write
            //string[] lines = new string[] { message };
            //File.AppendAllLines("log.txt", lines);


            string logMessage = $"{DateTime.Today:yyyy-MM-dd}: {message}\n";
            File.AppendAllText("log.txt", logMessage);


        }

        public static void ClearLogFile()
        {
            // Or File.Delete()
            // Or WriteAllText("");
            // File.Create("log.txt");
            File.WriteAllText("log.txt", "");
        }

        public static void WriteAmount(int amount)
        {
            string message = $"Amount is {amount:+##;-##;  0}";

            WriteToLog(message);
            Console.WriteLine($"Currency is {amount:C2}");

        }

        public static void WriteNegative(int amount)
        {
            WriteAmount(-amount);
        }
    }
}
