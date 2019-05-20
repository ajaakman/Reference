using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloading
{
    class Program
    {
        class Vector
        {
            public double x;
            public double y;

            // Overload + operator to add two Box objects.
            public static Vector operator +(Vector b, Vector c)
            {
                Vector box = new Vector();
                box.x = b.x + c.x;
                box.y = b.y + c.y;
                return box;
            }
        }

        static void Main(string[] args)
        {
            Vector A = new Vector
            {
                x = 4,
                y = 3
            };
            Vector B = new Vector
            {
                x = 7,
                y = 2
            };

            Vector C = A + B;

            Console.WriteLine("{0}, {1}", C.x, C.y);
            Console.Read();
        }
    }
}
