using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class IntToCheckController
    {
        protected IView _view;
        protected IntToString _model;
        protected int _number;

        public IntToCheckController(IView view, IntToString model)
        {
            _view = view;
            _model = model;
        }

        public void Go(int number)
        {
            _number = number;
            _model.SetNumber(_number);
            _view.DisplayOutput($"converting number {_number} to string");
            _view.DisplayOutput(_model.ConvertNumber());
            
        }
    }
}
