using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class CreatorA : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
