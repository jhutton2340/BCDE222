using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
           new SumAndAverageController(new SumAndAverageRange(), new ConsoleView()).Go();
        }
    }
}