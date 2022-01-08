using Patterns.AbstractFactory.ProductA;
using Patterns.AbstractFactory.ProductB;

namespace Patterns.AbstractFactory
{
    internal interface IAbstractFactory
    {
        public IProductA CreateProductA();

        public IProductB CreateProductB();
    }
}