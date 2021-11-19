using System;

namespace Fibonacci_Serise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine(" " + n1);
            int no = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=no;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(" "+n3);
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
