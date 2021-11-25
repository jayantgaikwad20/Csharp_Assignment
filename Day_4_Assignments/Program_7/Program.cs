using System;
//rp

namespace Program_GenericMethod_Swap
{

  /*  Create user defined generic class containing generic method swap.
        Use it for different datatypes and verify in main_rushikesh*/


    
    class Program
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 10,b = 20;
            char ch1='a', ch2='b';

            Console.WriteLine("Before Swap");
            Console.WriteLine("a= "+ a+" b="+b);
            Console.WriteLine("ch1= "+ch1 + "  ch2=" + ch2);
            swap(ref a, ref b);
            swap(ref ch1, ref ch2);

            Console.WriteLine("/n------");
            Console.WriteLine("after Swap");
            Console.WriteLine("a= " + a + " b=" + b);
            Console.WriteLine("ch1= " + ch1 + "  ch2=" + ch2);


        }
    }
}
