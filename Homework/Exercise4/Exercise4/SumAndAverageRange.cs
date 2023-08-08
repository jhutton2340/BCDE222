using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class SumAndAverageRange
    {
        protected int _numberToSum;

        public int CalculateSum()
        {
            for(int i = 0; i < 101; i++)
            {
                _numberToSum += i;
            }
            return _numberToSum;
        }

      

        public double AverageNumber()
        {
            return (double)_numberToSum / 100;
        }
    }
}
