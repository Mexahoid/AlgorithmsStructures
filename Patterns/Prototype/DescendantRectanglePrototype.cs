using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal class DescendantRectanglePrototype : RealPrototype
    {
        private (int x, int y) _mirror;

        private DescendantRectanglePrototype(DescendantRectanglePrototype source) : base(source)
        {
            _mirror.x = source._mirror.x;
            _mirror.y = source._mirror.y;
        }

        public DescendantRectanglePrototype(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            _mirror = (x2, y2);
        }

        public override void Print(Action<string> printer)
        {
            printer?.Invoke($"Rectangle left upper corner: x: {_point.x}, y: {_point.y}. Right lower corner: x: {_mirror.x}, y: {_mirror.y}");
        }

        public override IPrototype Clone()
        {
            var clone = new DescendantRectanglePrototype(this);
            return clone;
        }
    }
}
