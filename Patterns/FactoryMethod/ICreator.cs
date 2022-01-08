using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal interface ICreator
    {
        public void Operation();

        IProduct CreateProduct();
    }
}
