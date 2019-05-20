using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 5, 2, 8 };
            Array.Resize(ref myArray, 5);
            myArray[4] = 7;
            int[] myArray1 = myArray;

            foreach (var item in myArray)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            foreach (var item in myArray1)
                Console.Write("{0}, ", item);
            Console.WriteLine();
            var listofnum = new int[5] { 4, 6, 7, 6, 7};
            listofnum.Sum();

            myArray[2] = 10;

            foreach (var item in myArray)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            foreach (var item in myArray1)
                Console.Write("{0}, ", item);
            Console.WriteLine();
            // Multidimentional arrays.
            int[,] a = new int[3, 4] {
               {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
               {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
               {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            };
            // Jagged arrays.
            int[][] scores = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };

            
            int sum = AddElements(512, 720, 250, 567, 889);

            Console.WriteLine("The sum is: {0}", sum);

            Array.Sort(myArray);
            Array.Reverse(myArray);

            foreach (var item in myArray)
                Console.Write("{0}, ", item);
            Console.WriteLine(myArray[myArray.GetLowerBound(0)]);

           

            Console.Read();
        }

        public static int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

    }
}
