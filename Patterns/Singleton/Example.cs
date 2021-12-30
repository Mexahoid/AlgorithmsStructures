using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class Example
    {
        public static void Show()
        {
            ISingleton s = SimpleSingleton.Instance;
            s.Value = 20;
            Console.WriteLine($"Current SS value: {s.Value}");
            s.Value = 50;
            s = SimpleSingleton.Instance;
            Console.WriteLine($"New SS value: {s.Value}");



            s = LazySingleton.Instance;
            s.Value = 60;
            Console.WriteLine($"Current LS value: {s.Value}");
            s.Value = 70;
            s = LazySingleton.Instance;
            Console.WriteLine($"New LS value: {s.Value}");


            s = ThreadSafeSingleton.Instance;
            s.Value = 30;
            Console.WriteLine($"Current TSS value: {s.Value}");
            s.Value = 10;
            s = ThreadSafeSingleton.Instance;
            Console.WriteLine($"New TSS value: {s.Value}");
        }
    }
}
