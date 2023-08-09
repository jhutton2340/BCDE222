using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise11
{
    class CalculateProduct
    {
        protected int _product = 1;

        public int CalulateProduct(int endNumber)
        {
            for (int i = 1; i <= endNumber; i++)
            {
                _product *= i;
               
            }
            return _product;
        }
    }   
}
