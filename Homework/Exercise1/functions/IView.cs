using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    
    
    interface IView
    {
        void Start();

        void Stop();

        int SetNumber(int number);

        void Show<T>(T message);
    }
}
