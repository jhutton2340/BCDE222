using System;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            new Exercise11Controller(new ConsoleView(), new CalculateProduct()).Go(12);
        }
    }
}