using Patterns.AbstractFactory.ProductA;
using Patterns.AbstractFactory.ProductB;

namespace Patterns.AbstractFactory
{
    internal class Example
    {
        public static void Show()
        {
            IAbstractFactory factory = new Factory1();

            IProductA a = factory.CreateProductA();
            IProductB b = factory.CreateProductB();

            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);

            factory = new Factory2();

            a = factory.CreateProductA();
            b = factory.CreateProductB();
            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
        }
    }
}
