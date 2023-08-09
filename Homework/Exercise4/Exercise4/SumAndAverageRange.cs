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
            do
            {
                _numberToSum += i;
                i++;
            }while (i <= 100);
            return _numberToSum;
        }

      

        public double AverageNumber()
        {
            return (double)_numberToSum / 100;
        }
    }
}
