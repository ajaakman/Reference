using System;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Debug");
#elif RELEASE
            Console.WriteLine("Release");
#else
            Console.WriteLine("Unknown");
#endif
            Console.Read();
        }
    }
}
