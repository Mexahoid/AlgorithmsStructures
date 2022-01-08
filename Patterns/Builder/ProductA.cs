using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class ProductA
    {
        public List<string> Words { get; }

        public ProductA()
        {
            Words = new List<string>
            {
                "Product A"
            };
        }
    }
}
