using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class OddEvenChecker
    {
        protected int _numberToUse;

        public void SetNumber(int numberToUse)
        {
            _numberToUse = numberToUse;
        }

        public string CheckNumber()
        {
            if (_numberToUse % 2 == 0)
            {
                return "even number";
            }
            return "odd number";
        }
    }
}
