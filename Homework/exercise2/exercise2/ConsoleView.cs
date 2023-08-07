using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class ConsoleView : IView
    {
       public int SetNumber(int number)
        {
            return (number);
        }
       
       public void Show (string message)
        {
            Console.WriteLine(message);
        }
    }
}
