using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        public int Value { get; set; }

        private SimpleSingleton()
        {

        }

        public static SimpleSingleton Instance 
        { 
            get
            {
                if (_instance == null)
                    _instance = new();
                return _instance;
            }
        }
    }
}
