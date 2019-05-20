using System;

namespace Branches
{
    class Program
    {
        enum Grades { A, B, C, D, E, F };

        static void Main(string[] args)
        {
            object a = 10;
            if (a is float)
                Console.WriteLine("a is an float");
            else if (a is int)
                Console.WriteLine("a is an int");
            
            Console.WriteLine((5 == 5) ? 2 : 6);

            int grade = (int)Grades.B;
            switch (grade)
            {
                case (int)Grades.A:
                    Console.WriteLine("Excellent!");
                    break;
                case (int)Grades.B:
                case (int)Grades.C:
                    Console.WriteLine("Well done");
                    break;
                case (int)Grades.D:
                    Console.WriteLine("You passed");
                    break;
                case (int)Grades.F:
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
