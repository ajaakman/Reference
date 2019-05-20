using System;
using System.Text;

namespace Classes
{

    interface IBase
    {

    }

    interface IBase2
    {

    }

    abstract public class Base : IBase, IBase2
    {
        public Base(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract void Greeting();
        public virtual void SayName() { Console.WriteLine(Name); }
    }

    sealed public class Test : Base
    {
        private string myPrivateVar = "Private Var";
        public int myPublicVar = 55;
        internal int myInternalInt = 84;        

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

        public Test(string name) : base(name)
        {
            Console.WriteLine(myPrivateVar);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.myPrivateVar);
            return sb.ToString();
        }

        public override void Greeting()
        {
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test("My Name");
            Test1 test1 = new Test1();
            test.TwitterName = "@Hello";
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", test.Name, test.TwitterName, test.myPublicVar, test.myInternalInt, test.ToString());

            Greet(test);
            test.SayName();
            Console.Read();
        }

        static void Greet(Base b)
        {
            b.Greeting();
        }

    }
}
