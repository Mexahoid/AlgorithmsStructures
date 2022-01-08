using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class Example
    {
        public static void Show()
        {
            BuilderA builderA = new();
            BuilderB builderB = new();

            Director d = new(builderA);
            d.Make();

            ProductA pa = builderA.GetProduct();

            foreach (var item in pa.Words)
            {
                Console.WriteLine(item);
            }

            d.SetBuilder(builderB);
            d.Make();

            ProductB pb = builderB.GetProduct();

            foreach (var item in pb.Words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
