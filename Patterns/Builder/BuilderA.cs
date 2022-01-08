using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class BuilderA : IBuilder
    {
        private ProductA _product;

        public void BuildStepA()
        {
            _product.Words.Add("Step A from BB");
        }

        public void BuildStepB()
        {
            _product.Words.Add("Step B from BB");
        }

        public void BuildStepC()
        {
            _product.Words.Add("Step C from BB");
        }

        public void Reset()
        {
            _product = new ProductA();
        }

        public ProductA GetProduct()
        {
            return _product;
        }
    }
}
