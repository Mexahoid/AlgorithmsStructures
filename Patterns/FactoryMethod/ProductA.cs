using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class ProductA : IProduct
    {
        public void Operate(Action<string> printer)
        {
            printer?.Invoke("Product A");
        }
    }
}
