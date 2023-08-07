using exercise2;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Exercise2Controller(new ConsoleView(), new OddEvenChecker()).Run(3);
        }
    }
}
