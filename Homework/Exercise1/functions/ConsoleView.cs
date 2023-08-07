using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ConsoleView : IView
    {
        public void Start()
        {
            Console.Clear();
        }

        public void Stop()
        {
            Console.WriteLine("press any key to finish");
        }

        public int SetNumber(int number)
        {
            return (number);

        }

        public void Show<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
}
    
