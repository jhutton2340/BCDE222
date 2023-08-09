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
            int i = 0;
            while(i < 101)
            {
                _numberToSum += i;
                i++;
            }
            return _numberToSum;
        }

      

        public double AverageNumber()
        {
            return (double)_numberToSum / 100;
        }
    }
}
