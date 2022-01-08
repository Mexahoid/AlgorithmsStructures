using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class ProductB
    {
        public List<string> Words { get; }

        public ProductB()
        {
            Words = new List<string>
            {
                "Product B"
            };
        }
    }
}
