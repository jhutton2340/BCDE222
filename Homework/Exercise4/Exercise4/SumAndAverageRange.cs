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
        protected int _count;
        public int[] CalculateSum()
        {
            int i = 111;
            
            do
            {
                _numberToSum += i;
                _count += + 1;
                
                i++;


            } while (i <= 8990);
            int[] sumAndCount = new int[2];
            sumAndCount[1] = _numberToSum;
            sumAndCount[0] = _count;
            _numberToSum = 0;
            _count = 0;
            return sumAndCount;
            
        }



        public double AverageNumber()
        {
            return (double)_numberToSum / 100;
        }
    }
}
