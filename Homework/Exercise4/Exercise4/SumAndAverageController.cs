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
        protected int _number;

        public SumAndAverageController(SumAndAverageRange sumAndAverageRange, IView view)
        {
            _sumAndAverageRange = sumAndAverageRange;
            _view = view;

        }

        public void Go()
        {
            _number = _sumAndAverageRange.CalculateSum();
            _view.DisplayOutput($"the sum of numbers 1 to 100 are {_number}");
            _view.DisplayOutput($"the average of numbers 1 to 100 are {_sumAndAverageRange.AverageNumber()}");
            
        }
    }
}
