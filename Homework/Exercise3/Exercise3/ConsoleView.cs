using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class ConsoleView : IView
    {
        public int SetNumber(int number)
        {
            return number;
        }

        public void DisplayOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
    
}
