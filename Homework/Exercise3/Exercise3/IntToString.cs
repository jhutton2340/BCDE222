using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class IntToString
    {
        protected int _number;

        public void SetNumber(int numberToUse)
        {
            _number = numberToUse;
        }

        public string ConvertNumber()
        {
            return _number switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                _ => "unknown",
            };
        }
    }

}
