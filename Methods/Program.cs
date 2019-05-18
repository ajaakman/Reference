using System;

namespace Methods
{
    class Program
    {
        public static void PrintNum(int x)
        {
            Console.WriteLine(x);
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }

        public static void SetNum(out int x)
        {
            x = 20;
        }

        public static int AddNums(int x, int y) => x + y;

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;

            SetNum(out a);

            PrintNum(a);
            PrintNum(b);

            Swap(ref a, ref b);

            PrintNum(a);
            PrintNum(b);

            PrintNum(AddNums(5, 8));

            Console.Read();
        }
    }
}
