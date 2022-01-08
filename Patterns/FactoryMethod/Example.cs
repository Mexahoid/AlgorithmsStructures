using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class Example
    {
        public static void Show()
        {
            ICreator x = new CreatorA();
            IProduct z = x.CreateProduct();

            z.Operate(Console.WriteLine);

            x = new CreatorB();
            z = x.CreateProduct();

            z.Operate(Console.WriteLine);
        }
    }
}
