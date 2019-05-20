using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            try
            {
                Words.Add("Bread");
                Words.Add("Milk");
                Words.Add("Cheese");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally { }
            Console.Read();
        }
    }
}
