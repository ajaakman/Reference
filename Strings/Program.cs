using System;

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
            var message = string.Format("Hello World {0}", n);

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
