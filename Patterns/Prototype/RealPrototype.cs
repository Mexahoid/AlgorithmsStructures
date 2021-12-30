using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal abstract class RealPrototype : IPrototype
    {
        protected (int x, int y) _point;

        public RealPrototype(int x, int y)
        {
            _point = (x, y);
        }

        protected RealPrototype(RealPrototype source)
        {
            _point.x = source._point.x;
            _point.y = source._point.y;
        }

        public virtual void Print(Action<string> printer)
        {
            printer?.Invoke($"Center is on x: {_point.x}, y: {_point.y}");
        }

        public abstract IPrototype Clone();
    }
}
