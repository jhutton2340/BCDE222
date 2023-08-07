using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FunctionController
    {
        protected IView _view;
        protected FunctionsModel _model;
        protected int _number;

        public FunctionController(IView view, FunctionsModel model)
        {
            _view = view;
            _model = model;
            
        }

        public void Go(int numberCheck)
        {   
            _number = numberCheck;
            _view.Start();
            _model.SetNumber(numberCheck);
            _view.Show($"checking number {numberCheck}");
            string result = _model.CheckNumber();
            _view.Show(result);
            _view.Stop();
        }
    }

}
