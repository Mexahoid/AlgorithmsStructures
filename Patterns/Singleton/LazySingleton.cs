using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class LazySingleton : ISingleton
    {
        private class Nested
        {
            static Nested()
            {

            }

            public static readonly LazySingleton Instance = new();
        }

        public static LazySingleton Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        public int Value { get; set; }

        private LazySingleton()
        {

        }
    }
}
