using System;
using System.IO;

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            int? nullableInt = null;
            // Value Types
            bool myBool = true; //Boolean
            char myChar = 'A'; //Char
            byte myByte = 255; //Byte
            sbyte mySbyte = -128; //SByte
            short myShort = -32768; //Int16
            ushort myUshort = 65535; //UInt16
            int myInt = int.Parse("456"); //Int32
            uint myUint = uint.MaxValue; //UInt32
            long myLong = -9223372036854775808; //Int64
            ulong myUlong = 18446744073709551615; //UInt64
            float myFloat = 4.5F; //Single
            double myDouble = 5.5D; //Double
            decimal myDecimal = 6.5M; //Decimal
            
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}", 
                myShort, myUshort, myInt, myUint, myLong, myUlong, myBool, myChar, myByte, mySbyte, myFloat, myDouble, myDecimal, pi, nullableInt);

            Console.WriteLine("Size of int in bytes: {0}, type of int class {1}", sizeof(int), typeof(int));
            
            // Reference Types
            string myString = @"Hello World";
            object obj = myString; // Can be any type. Type checking at compile time.
            dynamic d = myString; // Type checking done at runtime.

            Console.WriteLine("{0}, {1}", obj, d);

            // Pointer Types
            unsafe
            {
                char* cptr = &myChar;
                int* iptr = &myInt;
                Console.WriteLine("{0}, {1}", *cptr, *iptr);
            }

            // Type Casting
            myInt = (int)myDouble;
            string tempString = myDouble.ToString();
            myDouble = Convert.ToDouble(tempString);

            tempString = myInt.ToString();
            myInt = Convert.ToInt32(tempString);

            tempString = myUint.ToString();
            myUint = Convert.ToUInt32(tempString);

            Console.WriteLine("{0}", myDouble);

            tempString = myBool.ToString();
            Console.WriteLine("{0}", tempString);
            tempString = "false";
            myBool = Convert.ToBoolean(tempString);
            Console.WriteLine("{0}", myBool);

            Object obj2 = new StringReader("Hello");
            StringReader r = obj2 as StringReader;

            Console.ReadLine();
        }
    }
}
