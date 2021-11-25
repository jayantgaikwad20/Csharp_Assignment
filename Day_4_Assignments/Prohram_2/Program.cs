using System;

namespace FourthDay_Assignment4_Program2_Equals
{

    class Equal_class
    {
        public string name;

        public Equal_class(string name)
        {
            this.name = name;
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Equal_class))
                return false;
            else
                return this.name == ((Equal_class)obj).name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Equal_class e = new Equal_class("one");
            Equal_class e1 = new Equal_class("two");

            Console.WriteLine(Object.Equals(e, e1));
        }
    }
}
