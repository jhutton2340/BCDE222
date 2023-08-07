using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class FunctionsModel
    {
        protected int _numberOne;

        public void SetNumber(int numberToCheck)
        {
            _numberOne = numberToCheck;
        }

        public string CheckNumber()
        {
            if(_numberOne <= 49)
            {
                return "FAIL";
            }
            else
            {
                return "PASS";
            }
        }

    }
}
