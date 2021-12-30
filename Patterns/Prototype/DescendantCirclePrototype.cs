using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal class DescendantCirclePrototype : RealPrototype
    {
        private int _radius;

        private DescendantCirclePrototype(DescendantCirclePrototype source) : base(source)
        {
            _radius = source._radius;
        }

        public DescendantCirclePrototype(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Print(Action<string> printer)
        {
            base.Print(printer);
            printer?.Invoke($"Circle radius is {_radius}");
        }

        public override IPrototype Clone()
        {
            var clone = new DescendantCirclePrototype(this);
            return clone;
        }
    }
}
