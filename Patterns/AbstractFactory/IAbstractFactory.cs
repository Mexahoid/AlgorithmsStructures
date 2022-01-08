using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    internal interface IAbstractFactory
    {
        public IProductA CreateProductA();

        public IProductB CreateProductB();
    }
}
