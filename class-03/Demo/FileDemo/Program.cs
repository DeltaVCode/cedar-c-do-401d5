using System;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.ClearLogFile();



            MyClass.ReadFromFile("test.txt");
            MyClass.OutputEvenLinesFromFile("test.txt");

            MyClass.WriteHi("hello.txt");

            MyClass.WriteNames("names.csv");
        }
    }
}
