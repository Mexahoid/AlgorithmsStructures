using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class BuilderB : IBuilder
    {
        private ProductB _product;

        public void BuildStepA()
        {
        }

        public void BuildStepB()
        {
            _product.Words.Add("Step B from BB");
        }

        public void BuildStepC()
        {
        }

        public void Reset()
        {
            _product = new ProductB();
        }

        public ProductB GetProduct()
        {
            return _product;
        }
    }
}
