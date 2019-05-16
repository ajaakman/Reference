using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escape Characters:
            \\ 	\ character
            \' 	' character
            \" 	" character
            \? 	? character
            \a Alert or bell
            \b Backspace
            \f Form feed
            \n Newline
            \r Carriage return
            \t Horizontal tab
            \v Vertical tab
            \xhh. . . Hexadecimal number of one or more digits. */
            int n = 55;
            string m = "asd sfafa " +
                "asds ";
            var message = string.Format("   Hello World {0} {1}", n, m);

            Console.WriteLine(message);
            Console.WriteLine(message.Length);

            message = message.ToUpper();
            Console.WriteLine(message);

            message = message.ToLower();
            Console.WriteLine(message);

            message = message.Trim();
            Console.WriteLine(message);

            StringBuilder sb = new StringBuilder();
            sb.Append("I am a StringBuilder");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
