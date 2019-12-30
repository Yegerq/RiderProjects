using System;
using System.IO;
using System.Linq;

namespace OOPlect
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
            Console.ReadLine();
        }

        private static void Foo()
        {
            var test = new Test();
            test.Dispose();
        }
    }
}
