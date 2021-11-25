using System;

namespace ThirdDay_Assignment3_Program6_IndexOut
{
/*
 * Rushikesh Patil
 * 
 * Program 6 -- >
 *
Create an array try to accept values from user handle IndexOutOfBounds Exception.
*/
    class Program
    {
        public static void ipArray(int [] a)
        {

            Console.Write("Input 5 elements in the array :\n");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array -- ");
            foreach(int it in a)
            {
                Console.WriteLine(it);
            }
            // for exception accessing element more than size of array
            a[6] = 1;

        }

        static void Main(string[] args)
        {
            int[] a = new int[5];


            try
            {
                ipArray(a);
        }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index out of bound--"+e.Message);
            }

            Console.ReadKey();
}
    }
}
