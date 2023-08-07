using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            new FunctionController(new ConsoleView(), new FunctionsModel()).Go(50);
        }
    }
}