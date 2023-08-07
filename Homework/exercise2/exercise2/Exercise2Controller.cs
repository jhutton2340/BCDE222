using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Exercise2Controller
    {
        protected OddEvenChecker _oddEvenChecker;
        protected IView _view;
        int _numberToCheck;

        public Exercise2Controller(IView view, OddEvenChecker model)
        {
            _view = view;
            _oddEvenChecker = model;
        }

        public void Run(int enteredNumber)
        {
            _numberToCheck = enteredNumber;
            _oddEvenChecker.SetNumber(_numberToCheck);
            _view.Show($"checking number {enteredNumber}");
            _view.Show(_oddEvenChecker.CheckNumber());
        }
            
          
    }
}
