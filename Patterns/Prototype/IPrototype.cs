using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    internal interface IPrototype
    {
        public IPrototype Clone();
    }
}
