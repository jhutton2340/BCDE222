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
            _numberTwo = _sumAndAverageRange.CalculateSum()[0];
            _numberOne = _sumAndAverageRange.CalculateSum()[1];
            _view.DisplayOutput($"the sum of numbers 111 to 8989 are {_numberOne}");
            _view.DisplayOutput($"the average of numbers 1 to 100 are {_sumAndAverageRange.AverageNumber()}");
            _view.DisplayOutput($"the count of numbers 111 to 8989 are {_numberTwo}");
            
        }
    }
}
