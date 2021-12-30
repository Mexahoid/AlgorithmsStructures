using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;

        public int Value { get; set; }

        private static readonly object _lock = new();

        private ThreadSafeSingleton()
        {

        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new ThreadSafeSingleton();
                    }
                return _instance;
            }
        }
    }
}
