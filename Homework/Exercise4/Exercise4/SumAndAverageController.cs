using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class SumAndAverageController
    {
        protected SumAndAverageRange _sumAndAverageRange;
        protected IView _view;
        protected int _numberOne;
        protected int _numberTwo;

        public SumAndAverageController(SumAndAverageRange sumAndAverageRange, IView view)
        {
            _sumAndAverageRange = sumAndAverageRange;
            _view = view;

        }

        public void Go()
        {
            
            _numberOne = _sumAndAverageRange.CalculateSum();
            _view.DisplayOutput($"the sum of all odd numbers between 1 and 100 are {_numberOne}");
            _view.DisplayOutput($"the average of numbers 1 to 100 are {_sumAndAverageRange.AverageNumber()}");
            
            
        }
    }
}
