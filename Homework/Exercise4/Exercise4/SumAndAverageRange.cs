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
        protected double _count;

        public int CalculateSum()
        {
            for (int i = 0; i <= 101; i++)
            {
                if(i % 7 == 0)
                {
                    _numberToSum += i;
                    _count++;
                }
                
                
            }

            return _numberToSum;

        }
        public double AverageNumber()
        {
            return (double)_numberToSum / _count;
        }
    }
}
