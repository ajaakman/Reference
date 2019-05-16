using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n < 1)
            {
                Console.WriteLine(n);                
                ++n;
            }

            do
            {
                Console.WriteLine(n);
                ++n;
            } while (n < 2);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);                
            }

            int[] arr = { 5, 4, 3, 2, 4 };

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.Write("\n");

            Console.Read();
        }
    }
}
