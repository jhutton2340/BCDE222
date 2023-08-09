using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise11
{
    class ConsoleView : IView
    {
       
        public void DisplayOutput(string output)
        {
            Console.WriteLine(output);
        }
    }

}
