using System;
using System.Text;

namespace Classes
{
    class Test
    {
        private string myPrivateVar = "Private Var";
        public int myPublicVar = 55;
        internal int myInternalInt = 84;
        public string Name { get; set; }

        private string _twitterAddress;
        public string TwitterName
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("Must begin with @");
                }
            }
        }

        public Test()
        {
            Console.WriteLine(myPrivateVar);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.myPrivateVar);
            return sb.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Test1 test1 = new Test1();
            test.Name = "Hello";
            test.TwitterName = "@Hello";
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", test.Name, test.TwitterName, test.myPublicVar, test.myInternalInt, test.ToString());
            Console.Read();
        }
    }
}
