using System;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.ClearLogFile();

            MyClass.WriteAmount(50);
            MyClass.WriteAmount(0);
            MyClass.WriteNegative(50);



            MyClass.ReadFromFile("test.txt");
            MyClass.OutputEvenLinesFromFile("test.txt");

            MyClass.WriteHi("hello.txt");

            MyClass.WriteNames("names.csv");
        }
    }
}
