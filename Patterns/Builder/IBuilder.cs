using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal interface IBuilder
    {
        public void Reset();

        public void BuildStepA();
        public void BuildStepB();
        public void BuildStepC();
    }
}
