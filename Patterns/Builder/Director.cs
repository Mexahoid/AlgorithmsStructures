using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void Make()
        {
            _builder.Reset();

            _builder.BuildStepA();
            _builder.BuildStepB();
            _builder.BuildStepC();
        }
    }
}
