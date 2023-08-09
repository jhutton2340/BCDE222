using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise11
{
    class Exercise11Controller
    {
        protected IView _view;
        protected CalculateProduct _calculateProduct;

        public Exercise11Controller(IView view, CalculateProduct calculateProduct)
        {
            _view = view;
            _calculateProduct = calculateProduct;
        }

        public void Go(int number)
        {
            int calculatedProduct = _calculateProduct.CalulateProduct(number);
            _view.DisplayOutput($"The product of all numbers between 1 and {number} is {calculatedProduct}");
        }
    }
}
