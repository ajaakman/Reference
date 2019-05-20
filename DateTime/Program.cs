using System;

namespace DT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            Console.Read();
        }
    }
}
