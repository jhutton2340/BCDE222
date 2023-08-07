using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            new IntToCheckController(new ConsoleView(), new IntToString()).Go(10);
        }
    }
}