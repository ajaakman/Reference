using System;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 10;
            if (a is float)
                Console.WriteLine("a is an float");
            else if (a is int)
                Console.WriteLine("a is an int");
            
            Console.WriteLine((5 == 5) ? 2 : 6);

            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);


            Console.Read();
        }
    }
}
