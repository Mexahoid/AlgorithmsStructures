using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal class Example
    {
        public static void Show()
        {
            IPrototype prot = new DescendantCirclePrototype(1, 2, 10);
            Console.WriteLine("Circle 1:");
            ((RealPrototype)prot).Print(Console.WriteLine);

            Console.WriteLine("Cloning circle");
            IPrototype prot2 = prot.Clone();

            Console.WriteLine("Circle 2:");
            ((RealPrototype)prot2).Print(Console.WriteLine);


            prot = new DescendantRectanglePrototype(1, 2, 4, 6);
            Console.WriteLine("Rectangle 1:");
            ((RealPrototype)prot).Print(Console.WriteLine);

            Console.WriteLine("Cloning rectangle");
            prot2 = prot.Clone();

            Console.WriteLine("Rectangle 2:");
            ((RealPrototype)prot2).Print(Console.WriteLine);
        }
    }
}
