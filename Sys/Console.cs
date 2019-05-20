using System;

namespace Console
{
    class Console
    {
        static void Main(string[] args)
        {
            int n;

            System.Console.WriteLine("Please Insert a Valid Number");
            n = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Your number is {0}", n);
            System.Console.ReadLine();
        }
    }
}
