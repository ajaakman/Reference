using System;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please Insert a Valid Number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is {0}", n);
            Console.ReadLine();
        }
    }
}
